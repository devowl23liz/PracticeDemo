namespace demo.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string UnitOfMeasure { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Supplier { get; set; }

    public string? Manufacturer { get; set; }

    public string? Category { get; set; }

    public decimal? CurrentDiscount { get; set; }

    public int? StockQuantity { get; set; }

    public string? Description { get; set; }

    public string? PhotoUrl { get; set; }
}
