using Application.Exceptions.Permissions;
using Application.Validations.Permissions;
using Domain.IdentityEntities;

namespace ClassHubUI.Controllers
{
    public partial class PermissionController
    {
        private static void ValidatePermissionExist(Permission? maybePermission,Guid Id)
        {
            if (maybePermission == null)
            {
                throw new NotFoundException<Permission>(Id);
            }
        }

        private async Task ValidatePermissionOnAddAsync(Permission permission)
        {
            await ValidatePermissionAsync(permission);
            await CheckAndThrowIfPermissionAlreadyExistsAsync(permission);
        }

        private static async Task ValidatePermissionAsync(Permission permission)
        {
            var validation = new PermissionValidator();
            var validationResult = await validation.ValidateAsync(permission);

            if (!validationResult.IsValid)
            {
                throw new InvalidEntityException<Permission>(validationResult.Errors);
            }
        }
        private async Task CheckAndThrowIfPermissionAlreadyExistsAsync(Permission permission)
        {
            var samePermissions = await permissionRepository.GetAsync(x =>
                x.PermissionName!.ToLower() == permission.PermissionName!.ToLower());

            if (samePermissions.Any())
            {
                throw new AlreadyExistException<Permission>(permission.PermissionName!);
            }
        }

        private static void ValidatePermissionNotNull(Permission permission)
        {
            if (permission == null) throw new NullEntityException<Permission>();
        }
    }
}
