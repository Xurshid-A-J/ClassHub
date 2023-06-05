using Application.Abstractions;
using Application.Exceptions.Permissions;
using Application.Interfaces.IEntityRepositories;
using Application.Validations.Permissions;
using Domain.IdentityEntities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IPermissionValidator permissionValidator;

        public PermissionRepository(
            IApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public override async Task<Permission> CreateAsync(Permission permission)
        {
          

            return await base.CreateAsync(permission);
        }

        public override async Task<Permission?> GetByIdAsync(Guid id)
        {
            var maybePermission = await base.GetByIdAsync(id);
          
            if (maybePermission == null)
            {
                throw new NotFoundException<Permission>(id);
            }

            return maybePermission;
        }
        private Task ValidatePermissionOnAddAsync(Permission permission)
        {
            //var validation = new PermissionValidator();
            //var validationResult = await validation.ValidateAsync(permission);

            //if (!validationResult.IsValid)
            //{
            //    throw new InvalidEntityException<Permission>(validationResult.Errors);
            //}

            return null;
        }
    }
}
