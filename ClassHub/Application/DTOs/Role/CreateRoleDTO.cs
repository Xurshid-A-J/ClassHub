using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Role
{
    public class CreateRoleDTO
    {
        public string RoleName { get; set; }
        public ICollection<Guid> PermissionIds { get; set; }= new HashSet<Guid>();
    }
}
