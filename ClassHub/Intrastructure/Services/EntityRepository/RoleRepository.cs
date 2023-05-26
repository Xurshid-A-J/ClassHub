using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly IApplicationDbContext dbContext;

        public RoleRepository(IApplicationDbContext dbContext) : base(dbContext)
            => this.dbContext = dbContext;
    }
}
