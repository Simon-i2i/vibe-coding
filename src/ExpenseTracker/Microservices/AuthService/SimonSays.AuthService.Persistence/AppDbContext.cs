using Microsoft.EntityFrameworkCore;
using SimonSays.AuthService.Domain;

namespace SimonSays.AuthService.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
} 