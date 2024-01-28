using Microsoft.EntityFrameworkCore;
using petcare.Domain;
using System.Reflection;

namespace petcare.Persistence
{
    public class PetDbContext : DbContext
    {
        public const string DefaultSchema = "public";

        public PetDbContext(DbContextOptions<PetDbContext> options)
        : base(options)
        {
        }
        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Notification> Notifications => Set<Notification>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
