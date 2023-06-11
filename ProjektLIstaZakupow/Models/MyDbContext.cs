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
            modelBuilder.Entity<Produkt>().HasData(new Produkt { Id = 1, CzyKupione = false, Nazwa = "Marchewka", Rodzaj = "Warzywa" },
                new Produkt { Id = 2, CzyKupione = false, Nazwa = "Kurczak", Rodzaj = "Mięso" },
                new Produkt { Id = 3, CzyKupione = false, Nazwa = "Cukierki", Rodzaj = "Słodycze" });
            modelBuilder.Entity<Produkt>().ToTable("Produkty");
        }
    }
}