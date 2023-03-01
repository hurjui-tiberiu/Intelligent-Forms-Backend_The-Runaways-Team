using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IUserService
    {
        public Task<string> Login();
        public Task LogOut();
        public Task<User> UpdateUser(User user);
        public Task SignUp();
        public Task ResetPassword(string Password);
    }
}
