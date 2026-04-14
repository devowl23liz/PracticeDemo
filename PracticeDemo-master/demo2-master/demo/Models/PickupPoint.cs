namespace demo.Models;

public partial class PickupPoint
{
    public int Id { get; set; }

    public string PointNumber { get; set; } = null!;

    public string Address { get; set; } = null!;
    public virtual ICollection<Order> Orders { get; set; }
}
