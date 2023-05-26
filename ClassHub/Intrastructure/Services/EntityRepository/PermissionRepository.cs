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
    internal class PermissionRepository : IPermissionRepository
    {
        public Task<Permission> CreateAsync(Permission entity)
        {
            throw new NotImplementedException();
        }

        public Task<Permission> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Permission>> GetAsync(Expression<Func<Permission, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Permission?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Permission> UpdateAsync(Permission entity)
        {
            throw new NotImplementedException();
        }
    }
}
