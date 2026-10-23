using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductInsight.Api.Data;
using ProductInsight.Api.Services;

namespace ProductInsight.Api.Controller;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _db;
    
    public ProductsController(AppDbContext db) {
        _db = db;
    }

    [HttpGet("{ean}")]
    public async Task<IActionResult> GetProduct(string ean) {
        
        if (!EanValidator.IsValid(ean))
        return BadRequest (new { message = "Cod EAN invalid"});
        var product = await _db.Products
        .Where(p => p.Ean == ean)
        .Select(p => new { p.Ean, p.Name, p.Category, p.ImageUrl})
        .FirstOrDefaultAsync();

        if (product is null)
        return NotFound(new { message = "Produsul nu a fost gasit"});
        return Ok(product);
    }
    [HttpGet("{ean}/reviews")]
    public async Task<IActionResult> GetReviews(string ean) {
       
        if (!EanValidator.IsValid(ean))
            return BadRequest (new { message = "Cod EAN invalid"});
        var exists = await _db.Products.AnyAsync(p => p.Ean == ean);
        if(!exists)
            return NotFound(new { message = "Produsul nu a fost gasit"});

        var reviews = await _db.Reviews
        .Where(r => r.ProductEan == ean)
        .Select(r => new { r.Id, r.Source, r.AuthorName, r.Text, r.Rating, r.Date})
        .ToListAsync();
        
        return Ok(reviews);
    }

    [HttpGet("{ean}/score")]
    public async Task<IActionResult> GetScore(string ean) {
       
        if (!EanValidator.IsValid(ean))
            return BadRequest (new { message = "Cod EAN invalid"});
        var ratings = await _db.Reviews
        .Where(r => r.ProductEan == ean)
        .Select(r => r.Rating)
        .ToListAsync();
        if(ratings.Count == 0)
        return NotFound(new { message = "Nu exista recenzii despre acest produs"});
        return Ok(new {
            Ean = ean,
            AverageRating = Math.Round(ratings.Average(), 2),
            ReviewsCount = ratings.Count
        });
    }
}

