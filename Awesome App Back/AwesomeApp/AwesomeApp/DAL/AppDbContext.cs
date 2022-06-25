using AwesomeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AwesomeApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
