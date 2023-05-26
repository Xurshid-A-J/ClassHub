using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    internal class StudentRepository : IStudentRepository
    {
        public Task<Student> CreateAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        public Task<Student> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Student>> GetAsync(Expression<Func<Student, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Student?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
