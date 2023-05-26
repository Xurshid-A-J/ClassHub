using Domain.Common;
using Domain.Entities.Groups;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Notices
{
    public class Notice:BaseAuditableEntity
    {
        public string? Title { get; set; }
        public string Content { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Guid ClassId { get; set; }
        public Group Group{ get; set; }

    }
}
