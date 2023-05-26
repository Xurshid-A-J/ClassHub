using Domain.Common;
using Domain.Entities.Assignments;
using Domain.Entities.Groups;
using Domain.Entities.Marks;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Students
{
    public class Student:UserEntity
    {
        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Mark> Marks { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
