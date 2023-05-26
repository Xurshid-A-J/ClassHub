using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEntityRepositories
{
    public interface ITeacherRepository: IRepository<Teacher>   
    {
    }
}
