﻿using AutoMapper;
using IbadahLover.Application.DTOs.DhikrType;
using IbadahLover.Application.DTOs.UserAccount;
using IbadahLover.Application.DTOs.UserActivity;
using IbadahLover.Application.DTOs.UserDhikrCount;
using IbadahLover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.profiles
{
    // Map Entities to Dtos, Application Layer to Domain Layer
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DhikrType, DhikrTypeDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserDhikrActivity, UserActivityDto>().ReverseMap();
            CreateMap<UserDhikrCount, UserDhikrCountDto>().ReverseMap();
        }
    }
}
