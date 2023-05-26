using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.IdentityEntities;
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

        public PermissionRepository(IApplicationDbContext dbContext) : base(dbContext)
            => this.dbContext = dbContext;
    }
}
