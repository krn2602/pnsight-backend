namespace ProductInsight.Api.Models;

public class AiEvaluation {
    public int Id { get; set; }
    public string ProductEan { get; set; } = string.Empty;

    public int Vandabilitate { get; set; }
    public int Calitate { get; set; }
    public int? RaportCalitatePret { get; set; }
    public int Durabilitate { get; set; }
    public int SatisfactieGenerala { get; set; }
    public int CredibilitateRecenzii { get; set; }
    public string Rezumat { get; set; } = string.Empty;
    public DateTime EvaluatedAt { get; set; }
    
    public Product? Product { get; set; }
    

}