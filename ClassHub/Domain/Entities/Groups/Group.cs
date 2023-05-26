using Domain.Common;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Groups
{
    public class Group : BaseAuditableEntity
    {
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
