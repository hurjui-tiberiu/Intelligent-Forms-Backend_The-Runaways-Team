using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> CreateAccount(User user)
        {
            throw new NotImplementedException();
        }

        public Task Login()
        {
            throw new NotImplementedException();
        }

        public Task LogOut()
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
