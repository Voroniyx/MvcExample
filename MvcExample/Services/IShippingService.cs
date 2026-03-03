namespace MvcExample.Services;

public interface IShippingService
{
    Task<int> GetEstimatedDaysAsync(int productId);
}