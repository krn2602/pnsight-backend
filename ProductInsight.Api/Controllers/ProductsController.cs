using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductInsight.Api.Data;

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
        var product = await _db.Products
        .Where(p => p.Ean == ean)
        .Select(p => new { p.Ean, p.Name, p.Category, p.ImageUrl})
        .FirstOrDefaultAsync();

        if (product is null)
        return NotFound(new { message = "Produsul nu a fost gasit"});
        return Ok(product);
    }
}