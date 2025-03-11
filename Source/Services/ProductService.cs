using AISmartCodeWithCSharp14.Models;

namespace AISmartCodeWithCSharp14.Services;

public class ProductService
{
    private readonly List<Product> _products = new()
    {
        new(1, "Laptop", 1200),
        new(2, "Keyboard", 50),
        new(3, "Monitor", 300),
        new(4, "Mouse", 30),
        new(5, "Tablet", 200)
    };
    /// Not AI-Optimized Query
    //public List<Product> GetExpensiveProducts()
    //{
    //    return _products.Where(p => p.Price > 100)
    //                    .OrderBy(p => p.Name)
    //                    .ToList(); // Eager execution
    //}

    // AI-Optimized Query
    public IEnumerable<Product> GetExpensiveProducts()
    {
        return _products.Where(p => p.Price > 100)
                        .OrderBy(p => p.Name)
                        .AsEnumerable(); // Optimized for in-memory processing
    }
}