using Microsoft.EntityFrameworkCore;
using NyDemo.Models;

namespace NyDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
