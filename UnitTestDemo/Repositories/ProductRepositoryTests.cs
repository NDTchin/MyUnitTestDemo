using Microsoft.EntityFrameworkCore;
using MyUnitTestDemo.Data;
using MyUnitTestDemo.Models;
using MyUnitTestDemo.Repositories;

namespace UnitTestDemo.Repositories;

public class ProductRepositoryTests
{
    private async Task<MyUnitTestDemoContext> GetInMemoryDbContextAsync()
    {
        var options = new DbContextOptionsBuilder<MyUnitTestDemoContext>()
            .UseSqlite("Filename=:memory:")
            .Options;
        var dbContext = new MyUnitTestDemoContext(options);
        await dbContext.Database.OpenConnectionAsync();
        await dbContext.Database.EnsureCreatedAsync();
        return dbContext;
    }
    
    [Fact]
    public async Task AddProduct_ShouldReturnNewProductWithId()
    {
        var dbContext = await GetInMemoryDbContextAsync();
        var productRepository = new ProductRepository(dbContext);
        var product = new Product() { Id = 3, Name = "Product1", Price = 100, ImageUrl = "GetInMemoryDbContextAsync"};
        var result = await productRepository.Save(product);
        Assert.NotNull(result);
        Assert.True(result.Id > 0);
        Assert.Equal("Product1", result.Name);
    }
}