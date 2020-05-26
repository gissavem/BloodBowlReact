﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBTeamManagerReact
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();

            CreateMap<RegisterModel, User>();

            CreateMap<UpdateModel, User>();

        }
    }
}
