using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.User;
using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IUsersService
    {
        public Task<User> UpdateUserAsync(Guid id, dynamic patchUserDto);
        public Task SignUpAsync(UserSignUpDto userSignUpDto);
        public Task<UserDto> GetUserById(Guid id);
        public Task<UserDto> GetUserByEmailAsync(string email);
        public Task<UserSignInResponseDto> SignInAsync(UserSignInDto userSignInDto);
    }
}
