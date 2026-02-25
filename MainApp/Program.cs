using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var products = new Product[]
    {
        new Product(1, "Prod1"),
        new Product(2, "Prod2"),
        new Product(3, "Prod3")
    };

        var user1 = new User("User1", products);
        var users = new List<User>
    {
        user1
    };
        var result = TryGetUserProducts(users, "User1");
        Console.WriteLine(string.Join(" ", (IEnumerable<Product>)result));
    }

    static Product[] TryGetUserProducts(IEnumerable<User> users, string userName)
    {
        var user = users.FirstOrDefault(u => u.Name == userName);
        return user?.Products;
    }
}
