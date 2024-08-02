using Microsoft.EntityFrameworkCore;
using UserMagmt.Models;

namespace UserMagmt.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
