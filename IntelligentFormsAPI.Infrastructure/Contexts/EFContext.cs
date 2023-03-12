using IntelligentFormsAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntelligentFormsAPI.Infrastructure.Contexts
{
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos("https://f447355d-0ee0-4-231-b9ee.documents.azure.com:443/",
    "FSQsotIEON6q0I18CON0jelb5ZJFXxkfoVNvWde9FfBQxO0o5pmvgUaRLXgFYIMOvS8Eh8EG2ViJACDbGZaloA==",
    "IntelligentFormsDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToContainer("Users").HasPartitionKey(u => u.Id);

            modelBuilder.Entity<Submission>().ToContainer("Submissions").HasPartitionKey(s => s.Id);

            modelBuilder.Entity<Form>().ToContainer("FormTemplates").HasPartitionKey(f => f.Id);

        }


        public DbSet<User> Users { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Form> FormTemplates { get; set; }


    }
}
