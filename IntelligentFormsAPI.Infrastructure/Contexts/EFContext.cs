using IntelligentFormsAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IntelligentFormsAPI.Infrastructure.Contexts
{
    public class EFcontext:DbContext
    {
        public EFcontext(DbContextOptions<EFcontext> options) : base(options)
        {
        }

        public DbSet<User> Users{ get; set; }
    }
}
