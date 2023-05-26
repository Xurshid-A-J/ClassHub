using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Marks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    internal class MarkRepository : IMarkRepository
    {
        private readonly IApplicationDbContext dbContext;

        public MarkRepository(IApplicationDbContext dbContext)
            => this.dbContext = dbContext;
        public Task<Mark> CreateAsync(Mark entity)
        {
            throw new NotImplementedException();
        }

        public Task<Mark> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Mark>> GetAsync(Expression<Func<Mark, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Mark?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Mark> UpdateAsync(Mark entity)
        {
            throw new NotImplementedException();
        }
    }
}
