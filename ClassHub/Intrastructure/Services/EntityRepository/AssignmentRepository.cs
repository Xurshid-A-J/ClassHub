using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        private readonly IApplicationDbContext dbContext;

        public AssignmentRepository(IApplicationDbContext dbContext):base(dbContext)
            =>this.dbContext = dbContext;

        public virtual async Task<Assignment> CreateAsync(Assignment entity)
        {
            dbContext.Assignments.Add(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public Task<Assignment> DeleteAsync(Guid Id)
        {
            dbContext.Set<T>
        }

        public Task<IQueryable<Assignment>> GetAsync(Expression<Func<Assignment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Assignment?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Assignment> UpdateAsync(Assignment entity)
        {
            throw new NotImplementedException();
        }
    }
}
