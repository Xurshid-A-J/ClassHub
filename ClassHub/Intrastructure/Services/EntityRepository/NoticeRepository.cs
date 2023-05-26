using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Notices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    internal class NoticeRepository : INoticeRepository
    {
        public Task<Notice> CreateAsync(Notice entity)
        {
            throw new NotImplementedException();
        }

        public Task<Notice> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Notice>> GetAsync(Expression<Func<Notice, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Notice?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Notice> UpdateAsync(Notice entity)
        {
            throw new NotImplementedException();
        }
    }
}
