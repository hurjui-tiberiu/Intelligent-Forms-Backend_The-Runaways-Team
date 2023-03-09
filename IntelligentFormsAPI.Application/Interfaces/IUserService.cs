using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IUserService
    {
        public Task<User> UpdateUserAsync(Guid id, dynamic patchUserDto);
        public Task SignUpAsync(UserSignUpDto userSignUpDto);
        public Task<UserDto> GetUserById(Guid id);
        public Task<UserDto> GetUserByEmailAsync(string email);
        public Task<UserSignInResponseDto> SignInAsync(UserSignInDto userSignInDto);
    }
}
