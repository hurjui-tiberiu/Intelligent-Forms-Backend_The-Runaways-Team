using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateAccount(User user);
        public Task Login();
        public Task LogOut();
        public Task<User> UpdateUser(User user);
        public Task SignUp();
    }
}
