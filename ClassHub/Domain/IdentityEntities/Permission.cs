using Domain.Common;

namespace Domain.IdentityEntities
{
    public class Permission : BaseAuditableEntity
    {
        public string? PermissionName { get; set; }

        public virtual ICollection<Role>? Roles { get; set; }
    }
}
