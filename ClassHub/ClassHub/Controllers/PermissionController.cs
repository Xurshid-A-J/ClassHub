using Application.DTOs.Permission;
using Application.Exceptions.Permissions;
using Application.Interfaces.IEntityRepositories;
using Application.Validations.Permissions;
using Domain.IdentityEntities;
using LazyCache;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Linq.Expressions;
using System.Reflection;

namespace ClassHubUI.Controllers
{
    public partial class PermissionController : ApiControllerBase<Permission>
    {
        private readonly IPermissionRepository permissionRepository;
        private readonly IMemoryCache memoryCache;
        private readonly IAppCache appCache;

        public PermissionController(IPermissionRepository permissionRepository)
            =>this.permissionRepository = permissionRepository;
        
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<GetPermissionDTO>>> GetAsync()
        {
            IEnumerable<Permission> permissions = await this.permissionRepository.GetAsync(x => true);

            IEnumerable<GetPermissionDTO> mappedPermissions = 
                _mapper.Map<IEnumerable<GetPermissionDTO>>(permissions);

          
            return Ok(mappedPermissions);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<ActionResult<GetPermissionDTO>> GetById(Guid Id)
        {
            Permission? maybePermission = await this.permissionRepository.GetByIdAsync(Id);
            ValidatePermissionExist(maybePermission,Id);

            GetPermissionDTO permissionDTO = _mapper.Map<GetPermissionDTO>(maybePermission);

            return Ok(permissionDTO);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<CreatePermissionDTO>> CreateAsync([FromQuery]CreatePermissionDTO permissionDTO)
        {
            Permission permission = _mapper.Map<Permission>(permissionDTO);
            await ValidatePermissionOnAddAsync(permission);
            
            await this.permissionRepository.CreateAsync(permission);

            return Ok(permissionDTO);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<UpdatePermissionDTO>> UpdateAsync([FromQuery]UpdatePermissionDTO permissionDTO)
        {
            Permission? storagePermission = await this.permissionRepository.GetByIdAsync(permissionDTO.Id);
            
            ValidatePermissionExist(storagePermission,permissionDTO.Id);
            _mapper.Map(permissionDTO,storagePermission!);
            await ValidatePermissionAsync(storagePermission!);
            await CheckAndThrowIfPermissionAlreadyExistsAsync(storagePermission!);
            
            await this.permissionRepository.UpdateAsync(storagePermission!);

            return Ok(_mapper.Map(storagePermission,permissionDTO));
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult> DeleteAsync(Guid Id)
        {
            Permission? storagePermission = await this.permissionRepository.GetByIdAsync(Id);
            ValidatePermissionExist(storagePermission,Id);

            await this.permissionRepository.DeleteAsync(storagePermission!);
            
            return Ok($"Permission deleted successfully !!! ");
        }
 
    }
}
