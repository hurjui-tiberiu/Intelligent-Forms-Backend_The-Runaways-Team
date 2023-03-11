using AutoMapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Mapper
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserSignUpDto, User>();
            
            CreateMap<User, UserDto>();
            
            CreateMap<UserPatchDto, User>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<User, UserSignInResponseDto>();

        }
    }
}
