using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;

namespace IntelligentFormsAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<string> Login()
        {
            throw new NotImplementedException();
        }

        public Task LogOut()
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(string Password)
        {
            throw new NotImplementedException();
        }

        public Task SignUp()
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
