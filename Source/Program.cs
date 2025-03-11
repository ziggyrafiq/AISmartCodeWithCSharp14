using AISmartCodeWithCSharp14.Services;

Console.WriteLine("Hello, from Ziggy Rafiq");

var productService = new ProductService();
var result = productService.GetExpensiveProducts();

Console.WriteLine("Expensive Products:");
result.ToList().ForEach(product => Console.WriteLine($"{product.Name} - ${product.Price}"));

Console.ReadLine();
