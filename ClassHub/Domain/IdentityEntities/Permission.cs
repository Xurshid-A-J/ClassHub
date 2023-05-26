using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IdentityEntities
{
    public class Permission : BaseAuditableEntity
    {
        public string? PermissionName { get; set; }

        public virtual ICollection<Role>? Roles { get; set; }
    }
}
