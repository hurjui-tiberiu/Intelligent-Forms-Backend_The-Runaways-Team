using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EFContext context;

        public UserRepository(EFContext context)
        {
            this.context = context;
        }

        public async Task<User> GetUserById(Guid id)
        {
            var user = await context.Users.FindAsync(id);
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.EmailAddress.Equals(email));
            return user;
        }

        public async Task CreateUserAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
