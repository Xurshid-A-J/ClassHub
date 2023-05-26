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
    internal class GroupRepository : IGroupRepository
    {
        private readonly IApplicationDbContext dbContext;

        public GroupRepository(IApplicationDbContext dbContext)
            => this.dbContext = dbContext;
        public Task<Group> CreateAsync(Group entity)
        {
            throw new NotImplementedException();
        }

        public Task<Group> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Group>> GetAsync(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Group?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Group> UpdateAsync(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}
