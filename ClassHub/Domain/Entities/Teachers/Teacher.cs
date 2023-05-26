using Domain.Common;
using Domain.Entities.Assignments;
using Domain.Entities.Groups;
using Domain.Entities.Marks;
using Domain.Entities.Notices;
using Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Teachers
{

    public class Teacher:UserEntity
    {
        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public ICollection<Notice> Notices { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }

}
    