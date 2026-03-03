namespace MvcExample.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQty { get; set; }
}

public class ProductDetailsViewModel
{
    public string Name { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public decimal FinalPrice { get; set; }
    public int Stock { get; set; }
    public int EstimatedShippingDays { get; set; }
    public bool IsLowStock => Stock < 5;
}