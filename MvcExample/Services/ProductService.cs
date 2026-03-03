using MvcExample.Data;
using MvcExample.Models;

namespace MvcExample.Services;

using Microsoft.EntityFrameworkCore;

public class ProductService(ApplicationDbContext context) : IProductService
{
    public async Task<Product?> GetByIdAsync(int id)
    {
        return await context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}