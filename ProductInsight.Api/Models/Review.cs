namespace ProductInsight.Api.Models;
public class Review {
    public int Id { get; set; }
    public string ProductEan { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
    public string? AuthorName { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Rating { get; set; }
    public DateTime Date { get; set; }
    public Product? Prodcut { get; set; }
}