using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyUnitTestDemo.Data;
using MyUnitTestDemo.Models;

namespace MyUnitTestDemo.Repositories;

public class ProductRepository
{
    private MyUnitTestDemoContext _context;
    
    public ProductRepository(MyUnitTestDemoContext context)
    {
        _context = context;
    }
    
    public async Task<Product> Save(Product product)
    {
        var result = await _context.Product.AddAsync(product);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
}