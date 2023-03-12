using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IntelligentFormsAPI.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly EFContext context;

        public UsersRepository(EFContext context)
        {
            this.context = context;
        }

        public async Task<User?> GetUserById(Guid id)
        {
            var user = await context.Users.FindAsync(id);
            return user;
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.EmailAddress.Equals(email));
            return user;
        }

        public async Task<User?> GetUserByName(string name)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Name.Equals(name));
            return user;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task UpdateUserAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
