using Application.Exceptions.Permissions;
using Domain.IdentityEntities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Validations.Permissions
{
    public class PermissionValidator : AbstractValidator<Permission>, IPermissionValidator
    {
        public PermissionValidator()
        {
            RuleFor(x => x.PermissionName).Matches("^[a-zA-Z]+$")
                .WithMessage("Permission name must contain only letters,and not empty");
        }

    }
}
