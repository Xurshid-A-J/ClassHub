using Domain.IdentityEntities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations.Permissions
{
    public interface IPermissionValidator : IValidator<Permission>
    {
    }
}
