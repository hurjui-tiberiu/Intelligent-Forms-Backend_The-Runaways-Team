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
        public Task<User?> GetUserByEmail(string email);
        public Task UpdateUserAsync(User user);
        public Task<User> CreateUserAsync(User user);
        public Task<User?> GetUserById(Guid id);
        public Task<User?> GetUserByName(string name);
    }
}
