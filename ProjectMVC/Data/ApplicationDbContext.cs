using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", NumberOfItems=5},
                new Category { CategoryId = 2, Name = "Comdey", NumberOfItems=10},
                new Category { CategoryId = 3, Name = "Romantic", NumberOfItems=15}
                );
        }
    }
}
