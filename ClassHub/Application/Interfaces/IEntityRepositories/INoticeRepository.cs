using Domain.Entities.Notices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEntityRepositories
{
    public interface INoticeRepository: IRepository<Notice>
    {
    }
}
