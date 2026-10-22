using Microsoft.EntityFrameworkCore;
using ProductInsight.Api.Models;

namespace ProductInsight.Api.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().HasKey(p => p.Ean);
        
        modelBuilder.Entity<Product>().HasData (
            new Product {
                Ean = "5901234123457",
                Name = "Cafetiera ",
                Category = "electrocasnice",
                ImageUrl = null,
                LastLookupDate = new DateTime(2026,10,1)

            },
            new Product {
                Ean = "4006381333931",
                Name = "Set markere Faber",
                Category = "Papetarie", 
                ImageUrl = null,
                LastLookupDate = new DateTime(2026,10,1)
            }
        );
        modelBuilder.Entity<Review>().HasData(
           new Review { Id = 1, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Ana", Text = "Face o cafea bună, dar e zgomotoasă.", Rating = 4, Date = new DateTime(2026, 9, 10) },
        new Review { Id = 2, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Mihai", Text = "După 3 luni s-a stricat pompa.", Rating = 2, Date = new DateTime(2026, 9, 15) },
        new Review { Id = 3, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Elena", Text = "Raport calitate/preț excelent.", Rating = 5, Date = new DateTime(2026, 9, 20) },
        new Review { Id = 4, ProductEan = "4006381333931", Source = "Seed", AuthorName = "Radu", Text = "Culori vii, nu se usucă repede.", Rating = 5, Date = new DateTime(2026, 9, 12) },
        new Review { Id = 5, ProductEan = "4006381333931", Source = "Seed", AuthorName = "Ioana", Text = "Mi se pare cam scump pentru ce oferă.", Rating = 3, Date = new DateTime(2026, 9, 18) });
    
    

}
}
