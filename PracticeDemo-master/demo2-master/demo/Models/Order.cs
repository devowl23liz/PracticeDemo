namespace demo.Models;

public partial class Order
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public string OrderArticles { get; set; } = null!;
    public int PickupPointId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string CustomerFullName { get; set; } = null!;

    public string PickupCode { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public virtual PickupPoint PickupPoint { get; set; }
}
