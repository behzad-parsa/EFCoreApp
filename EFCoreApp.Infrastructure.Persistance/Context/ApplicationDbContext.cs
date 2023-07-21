using EFCoreApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Infrastructure.Persistance.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=EFCoreApp;Integrated Security=true;Encrypt=false;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}