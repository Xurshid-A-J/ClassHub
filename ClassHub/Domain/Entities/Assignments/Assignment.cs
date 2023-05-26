using Domain.Common;
using Domain.Entities.Groups;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Assignments
{
    public class Assignment:BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
