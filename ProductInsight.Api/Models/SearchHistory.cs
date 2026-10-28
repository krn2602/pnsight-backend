using Microsoft.Extensions.Configuration.UserSecrets;

namespace ProductInsight.Api.Models;

public class SearchHistory {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Ean { get; set; } = string.Empty;
    public DateTime SearchedAt { get; set; } 

    public User? User { get; set; }

}