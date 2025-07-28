using ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ecommerce.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
