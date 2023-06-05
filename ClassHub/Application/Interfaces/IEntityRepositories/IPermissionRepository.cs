using Application.Validations.Permissions;
using Domain.IdentityEntities;

namespace Application.Interfaces.IEntityRepositories
{
    public interface IPermissionRepository: IRepository<Permission>
    {
    }
}
