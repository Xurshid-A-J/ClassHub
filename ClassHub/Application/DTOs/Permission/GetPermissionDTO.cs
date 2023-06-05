using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Permission
{
    public class GetPermissionDTO
    {
        public Guid Id { get; set; }
        public string? PermissionName { get; set; }
    }
}
