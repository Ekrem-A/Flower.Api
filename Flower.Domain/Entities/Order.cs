namespace Flower.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;
    public string DeliveryAddress { get; set; } = string.Empty;
    public DateTime DeliveryTime { get; set; } = DateTime.UtcNow.AddHours(2);
    public string Status { get; set; } = "pending";   // pending, preparing, on-the-way, delivered

    public void SetStatus(string status)
    {
        // buraya validation bile koyarsın
        Status = status;
    }
}
