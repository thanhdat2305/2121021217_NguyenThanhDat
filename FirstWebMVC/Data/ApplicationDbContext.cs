using FirstWebMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
    }
}