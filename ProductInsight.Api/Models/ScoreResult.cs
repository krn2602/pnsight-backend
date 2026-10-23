namespace ProductInsight.Api.Models;

public enum Verdict {
        Slab,
        Mediu,
        Bun
    }

public class ScoreResult {
    public int Id { get; set;}
    public string ProductEan { get; set; } = string.Empty;
    public double AverageRating { get; set; }
    public int ReviewsCount { get; set; }
    public Verdict Verdict { get; set; }
    public DateTime CalculatedAt { get; set; }

    public Product? Product { get; set;}

}