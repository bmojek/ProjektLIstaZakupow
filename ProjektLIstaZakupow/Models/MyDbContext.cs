using Microsoft.EntityFrameworkCore;

namespace ProjektLIstaZakupow.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Produkt> Produkty { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produkt>().ToTable("Produkty");
        }
    }
}