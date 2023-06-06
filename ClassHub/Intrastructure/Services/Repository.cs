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
        
        public virtual async Task<T> CreateAsync(T entity)
        {
           await this._dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> DeleteAsync(T entity)
        {
            this._dbContext.Set<T>().Remove(entity);
            await this._dbContext.SaveChangesAsync();
            
            return entity;
        }

        public virtual Task<IQueryable<T>> GetAsync(Expression<Func<T, bool>> expression)
        {
            Thread.Sleep(3000);
            return Task.FromResult( this._dbContext.Set<T>().Where(expression));
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await this._dbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            this._dbContext.Set<T>().Update(entity);
            await this._dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
