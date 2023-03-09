using AutoMapper;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using Newtonsoft.Json;
using System.Text.Json;

namespace IntelligentFormsAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> GetUserById(Guid id)
        {
            var user = await userRepository.GetUserById(id);
            return mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await userRepository.GetUserByEmail(email);
            return mapper.Map<UserDto>(user);

        }

        public async Task<UserSignInResponseDto> SignInAsync(UserSignInDto userLoginDto)
        {
            var user = await userRepository.GetUserByEmail(userLoginDto.EmailAddress);

            if (user is null)
                throw new UnauthorizedAccessException("Account does not exist");
            
            if (!user.EmailAddress.Equals(userLoginDto.EmailAddress) || !userLoginDto.Password.Equals(user.Password))
                throw new UnauthorizedAccessException("Invalid email or password");
            
            return mapper.Map<UserSignInResponseDto>(user);
        }

        public async Task SignUpAsync(UserSignUpDto userSignUpDto)
        {
            var user = mapper.Map<User>(userSignUpDto);
            await userRepository.CreateUserAsync(user);
        }

        public async Task<User> UpdateUserAsync(Guid id, dynamic userPatchDto)
        {
            var patchUserDto = JsonConvert.DeserializeObject<UserPatchDto>(userPatchDto.ToString());
            var user = await userRepository.GetUserById(id);
            if (user != null)
            {
                var mappedUser = mapper.Map<UserPatchDto, User>(patchUserDto, user);
                await userRepository.UpdateUserAsync(mappedUser);
                return mappedUser;
            }

            return null;
        }
    }
}
