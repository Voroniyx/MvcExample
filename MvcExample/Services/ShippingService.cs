namespace MvcExample.Services;

using System.Net.Http.Json;

public class ShippingService(HttpClient httpClient) : IShippingService
{
    public async Task<int> GetEstimatedDaysAsync(int productId)
    {
        var response = await httpClient
            .GetFromJsonAsync<dynamic>($"https://api.lf12.voroniyx.xyz/rates/{productId}");

        return (int)response.estimatedDays;
    }
}