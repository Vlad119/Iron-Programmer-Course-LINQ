public class User
{
    public string Name { get; set; }
    public Product[] Products { get; set; }

    public User(string name, Product[] products)
    {
        Name = name;
        Products = products;
    }
}