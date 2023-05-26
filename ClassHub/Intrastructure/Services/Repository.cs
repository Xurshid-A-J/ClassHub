using Application.Abstractions;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IApplicationDbContext _dbContext;

        public Repository(IApplicationDbContext dbContext) 
            =>_dbContext = dbContext;
        
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }


    }
}
