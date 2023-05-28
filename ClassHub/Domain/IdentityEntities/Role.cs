using Domain.Common;

namespace Domain.IdentityEntities
{
    public class Role : BaseAuditableEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Permission>? Permissions { get; set; }
        public virtual ICollection<UserEntity>? UserRoles { get; set; }
    }
}
