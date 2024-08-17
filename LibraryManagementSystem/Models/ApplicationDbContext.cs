using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base( options) { }

        public DbSet<User> Users { get; set; }  // Change to public DbSet<User> Users { get; set; }
    }
}
