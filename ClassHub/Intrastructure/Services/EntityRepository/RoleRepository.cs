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
    internal class RoleRepository : IRoleRepository
    {
        public Task<Role> CreateAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<Role> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Role>> GetAsync(Expression<Func<Role, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Role?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
