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
        public PermissionRepository(
            IApplicationDbContext dbContext) : base(dbContext)
        { }

    }
}
