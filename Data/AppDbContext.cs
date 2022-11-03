using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WepApp.Models;

namespace WepApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }

       public DbSet<Item> Items { get; set; }

    }
}
