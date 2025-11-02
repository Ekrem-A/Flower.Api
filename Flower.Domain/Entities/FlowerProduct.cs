namespace Flower.Domain.Entities;

public class FlowerProduct
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;     // "FLR-001"
    public string Name { get; set; } = string.Empty;     // "Pembe Gül Buketi"
    public string Category { get; set; } = "bouquet";    // bouquet, orchid, indoor
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    // business rule örneği:
    public void MarkAsUnavailable()
    {
        IsAvailable = false;
    }
}
