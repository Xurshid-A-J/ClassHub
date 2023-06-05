using Application.DTOs.Permission;
using AutoMapper;
using Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Permission, GetPermissionDTO>().ReverseMap();
            CreateMap<Permission,CreatePermissionDTO>().ReverseMap();
            //CreateMap(typeof(Permission), typeof(GetPermissionDTO));
            
            
        }


    }
}
