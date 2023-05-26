using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Teachers;
using Intrastructure.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    internal class TeacherRepository : ITeacherRepository
    {
        private readonly IApplicationDbContext dbContext;

        public TeacherRepository(IApplicationDbContext dbContext)
            => this.dbContext = dbContext;

        public Task<Teacher> CreateAsync(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Teacher>> GetAsync(Expression<Func<Teacher, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> UpdateAsync(Teacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
