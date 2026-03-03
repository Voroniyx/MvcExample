using Microsoft.EntityFrameworkCore;
using MvcExample.Models;

namespace MvcExample.Data;


public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}