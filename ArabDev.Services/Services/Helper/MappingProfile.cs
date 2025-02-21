using ArabDev.Data.DataOrEntities;
using ArabDev.Services.Services.DTOS;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Services.Services.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDetailsDto>()
                .ForMember(d=>d.PictureUrl,o=>o.MapFrom<UserPictureURlResolve>());
               
        }

    }
}
