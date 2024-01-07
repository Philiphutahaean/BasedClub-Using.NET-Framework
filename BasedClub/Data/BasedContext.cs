using BasedClub.Models;
using Microsoft.EntityFrameworkCore;
namespace BasedClub.Data;
public class BasedContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder
   optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data source=BasedClub.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }
}