using Domain.Common;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Marks
{
    public class Mark:BaseAuditableEntity
    {
        public int Value { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
