namespace ProductInsight.Api.Models;

public class Product {
    public string Ean { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime LastLookupDate { get; set; }

    public List<Review> Reviews { get; set;} = new();

}
