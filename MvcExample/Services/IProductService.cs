using MvcExample.Models;

namespace MvcExample.Services;

public interface IProductService
{
    Task<Product?> GetByIdAsync(int id);
}