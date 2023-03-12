using AutoMapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.User;
using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Application.Mapper
{
    public class UserProfile : Profile
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
