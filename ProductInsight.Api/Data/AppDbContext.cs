using Microsoft.EntityFrameworkCore;
using ProductInsight.Api.Models;

namespace ProductInsight.Api.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<ScoreResult> ScoreResult => Set<ScoreResult>();

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
            },
            new Product { 
                Ean = "5941234567899",
                Name = "Casti wireless Sony",
                Category = "Electronice",
                LastLookupDate = new DateTime(2026, 10, 1) 
            },
            new Product { 
                Ean = "5901111111119",
                Name = "Aspirator Turbo Clean",
                Category = "Electrocasnice",
                LastLookupDate = new DateTime(2026, 10, 1) 
            },
            new Product {
                Ean = "5902222222220",
                Name = "Sticla termica Frost 500ml",
                Category = "Sport",
                LastLookupDate = new DateTime(2026, 10, 1) 
            });

        modelBuilder.Entity<Review>().HasData(
        new Review { Id = 1, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Ana", Text = "Face o cafea buna, dar e zgomotoasa.", Rating = 4, Date = new DateTime(2026, 9, 10) },
        new Review { Id = 2, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Mihai", Text = "Dupa 3 luni s-a stricat pompa.", Rating = 2, Date = new DateTime(2026, 9, 15) },
        new Review { Id = 3, ProductEan = "5901234123457", Source = "Seed", AuthorName = "Elena", Text = "Raport calitate/pret excelent.", Rating = 5, Date = new DateTime(2026, 9, 20) },
        new Review { Id = 4, ProductEan = "4006381333931", Source = "Seed", AuthorName = "Radu", Text = "Culori vii, nu se usuca repede.", Rating = 5, Date = new DateTime(2026, 9, 12) },
        new Review { Id = 5, ProductEan = "4006381333931", Source = "Seed", AuthorName = "Ioana", Text = "Mi se pare cam scump pentru ce ofera.", Rating = 3, Date = new DateTime(2026, 9, 18) },
        new Review { Id = 6, ProductEan = "5941234567899", Source = "Seed", AuthorName = "Vlad", Text = "Sunet foarte bun si baterie care tine.", Rating = 5, Date = new DateTime(2026, 9, 5) },
        new Review { Id = 7, ProductEan = "5941234567899", Source = "Seed", AuthorName = "Maria", Text = "Confortabile, dar microfonul e slab.", Rating = 4, Date = new DateTime(2026, 9, 9) },
        new Review { Id = 8, ProductEan = "5941234567899", Source = "Seed", AuthorName = "Dan", Text = "Cel mai bun raport calitate/pret din categorie.", Rating = 5, Date = new DateTime(2026, 9, 14) },
        new Review { Id = 9, ProductEan = "5901111111119", Source = "Seed", AuthorName = "Carmen", Text = "Aspia slab si face mult zgomot.", Rating = 2, Date = new DateTime(2026, 9, 3) },
        new Review { Id = 10, ProductEan = "5901111111119", Source = "Seed", AuthorName = "Sorin", Text = "S-a stricat motorul dupa o luna.", Rating = 1, Date = new DateTime(2026, 9, 11) },
        new Review { Id = 11, ProductEan = "5901111111119", Source = "Seed", AuthorName = "Laura", Text = "Merge decent pe suprafete mici.", Rating = 3, Date = new DateTime(2026, 9, 19) },
        new Review { Id = 12, ProductEan = "5902222222220", Source = "Seed", AuthorName = "Andrei", Text = "Tine apa rece toata ziua.", Rating = 4, Date = new DateTime(2026, 9, 7) },
        new Review { Id = 13, ProductEan = "5902222222220", Source = "Seed", AuthorName = "Bianca", Text = "Capacul se desface greu, altfel e ok.", Rating = 3, Date = new DateTime(2026, 9, 16) 
        });
        
        
        modelBuilder.Entity<ScoreResult>().HasData (
        new ScoreResult { Id = 1, ProductEan = "5901234123457", AverageRating = 3.67, ReviewsCount = 3, Verdict = Verdict.Mediu, CalculatedAt = new DateTime(2026, 10, 2) },
        new ScoreResult { Id = 2, ProductEan = "4006381333931", AverageRating = 4.0, ReviewsCount = 2, Verdict = Verdict.Bun, CalculatedAt = new DateTime(2026, 10, 2) },
        new ScoreResult { Id = 3, ProductEan = "5941234567899", AverageRating = 4.67, ReviewsCount = 3, Verdict = Verdict.Bun, CalculatedAt = new DateTime(2026, 10, 2) },
        new ScoreResult { Id = 4, ProductEan = "5901111111119", AverageRating = 2.0, ReviewsCount = 3, Verdict = Verdict.Slab, CalculatedAt = new DateTime(2026, 10, 2) },
        new ScoreResult { Id = 5, ProductEan = "5902222222220", AverageRating = 3.5, ReviewsCount = 2, Verdict = Verdict.Mediu, CalculatedAt = new DateTime(2026, 10, 2) 
        });
        
    }
}