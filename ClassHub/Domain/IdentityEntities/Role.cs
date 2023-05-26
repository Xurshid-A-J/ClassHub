using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IdentityEntities
{
    public class Role : BaseAuditableEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Permission>? Permissions { get; set; }
        public virtual ICollection<UserEntity>? UserRoles { get; set; }
    }
}
