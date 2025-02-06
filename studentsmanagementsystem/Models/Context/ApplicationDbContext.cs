using Microsoft.EntityFrameworkCore;
using studentsmanagementsystem.Models;

namespace studentsmanagementsystem.Context
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor with DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet for Student entity
        public DbSet<Student> Students { get; set; } = null!;
    }
}
