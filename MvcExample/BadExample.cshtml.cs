namespace MvcExample;

internal class ProductObj
{
    public string Name { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
}

internal class ShippingResponse
{
    public int estimatedDays { get; init; }
}