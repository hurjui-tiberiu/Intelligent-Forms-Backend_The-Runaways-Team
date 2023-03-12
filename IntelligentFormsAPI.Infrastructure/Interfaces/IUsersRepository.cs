using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        public Task<User?> GetUserByEmail(string email);
        public Task UpdateUserAsync(User user);
        public Task<User> CreateUserAsync(User user);
        public Task<User?> GetUserById(Guid id);
        public Task<User?> GetUserByName(string name);
    }
}
