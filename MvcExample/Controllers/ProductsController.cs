using MvcExample.Models;
using MvcExample.Services;

namespace MvcExample.Controllers;

using Microsoft.AspNetCore.Mvc;

public class ProductsController(
    IProductService productService,
    IShippingService shippingService)
    : Controller
{
    private const decimal TaxRate = 0.15m;

    public async Task<IActionResult> Details(int id)
    {
        var product = await productService.GetByIdAsync(id);

        if (product == null)
            return NotFound();

        var shippingDays = await shippingService.GetEstimatedDaysAsync(id);

        var finalPrice = product.Price + (product.Price * TaxRate);

        var vm = new ProductDetailsViewModel
        {
            Name = product.Name,
            BasePrice = product.Price,
            FinalPrice = finalPrice,
            Stock = product.StockQty,
            EstimatedShippingDays = shippingDays
        };

        return View(vm);
    }
}