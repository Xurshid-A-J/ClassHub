using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        private readonly IApplicationDbContext dbContext;

        public GroupRepository(IApplicationDbContext dbContext):base(dbContext)
            => this.dbContext = dbContext;
    }
}
