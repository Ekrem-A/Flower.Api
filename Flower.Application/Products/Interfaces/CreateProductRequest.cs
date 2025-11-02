namespace Flower.Application.Products.Interfaces;

public class CreateProductRequest
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = "bouquet";
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}

public class UpdateProductRequest : CreateProductRequest
{
    public bool IsAvailable { get; set; } = true;
}
