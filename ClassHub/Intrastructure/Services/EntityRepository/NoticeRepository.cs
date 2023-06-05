using Application.Abstractions;
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
    public class NoticeRepository :Repository<Notice>, INoticeRepository
    {
        public NoticeRepository(IApplicationDbContext dbContext) : base(dbContext)
        { }
    }
}
