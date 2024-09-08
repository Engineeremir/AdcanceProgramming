// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var category = new Category();
var product = new Product { CategoryId = 1 , Name = "Apple" };
var test = category + product;
foreach (var item in test.Products)
{
    Console.WriteLine($"{item.CategoryId} : {item.Name}");
}
public class Category
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = new();
    public static Category operator +(Category category, Product product)
    {
        category.Products.Add(product);
        return category;
    }
}

public class Product
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
}

