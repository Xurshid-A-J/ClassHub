using Application.DTOs.Permission;
using Application.Exceptions.Permissions;
using Application.Interfaces.IEntityRepositories;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ClassHubUI.Controllers
{
    public class PermissionController : ApiControllerBase<Permission>
    {
        private readonly IPermissionRepository permissionRepository;

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


        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<GetPermissionDTO>> GetById(Guid Id)
        {
            Permission maybePermission = await this.permissionRepository.GetByIdAsync(Id) 
                ?? new Permission(); // VALIDATION NEEDED

            GetPermissionDTO permissionDTO = _mapper.Map<GetPermissionDTO>(maybePermission);

            return Ok(permissionDTO);
        }


        [HttpPost("[action]")]
        public async Task<ActionResult<CreatePermissionDTO>> CreateAsync(CreatePermissionDTO permissionDTO)
        {
            Permission permission = _mapper.Map<Permission>(permissionDTO);

            Permission maybePermission = await this.permissionRepository.CreateAsync(permission);
            CreatePermissionDTO permissionDTO_result = _mapper.Map<CreatePermissionDTO>(maybePermission);

            return Ok(permissionDTO_result);
        }


        [HttpPut("[action]")]
        public async Task<ActionResult<GetPermissionDTO>> UpdateAsync(Permission permission)
        {
            Permission maybePermission = await this.permissionRepository.GetByIdAsync(permission.Id);

            GetPermissionDTO mappedPermissions =_mapper.Map<GetPermissionDTO>(permission);

            return Ok(mappedPermissions);
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<GetPermissionDTO>> DeleteAsync(Guid Id)
        {
            IEnumerable<Permission> permissions = await this.permissionRepository.GetAsync(x => true);

            IEnumerable<GetPermissionDTO> mappedPermissions =
                _mapper.Map<List<GetPermissionDTO>>(permissions.ToList());

            return Ok(mappedPermissions.ToList());
        }
    }
}
