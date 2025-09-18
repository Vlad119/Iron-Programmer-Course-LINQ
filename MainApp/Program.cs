using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var user1 = new User() { Name = "Петя", Age = 15 };
        var user2 = new User() { Name = "Вася", Age = 18 };
        var user3 = new User() { Name = "Оля", Age = 20 };
        var user4 = new User() { Name = "Маша", Age = 20 };
        var users = new List<User>();
        users.Add(user1);
        users.Add(user2);
        users.Add(user3);
        users.Add(user4);
        var users18 = GetAdulthood(users);
        foreach (var user in users18)
        {
            Console.WriteLine($"Пользователь {user.Name}, возраст {user.Age}");
        }
    }

    static IEnumerable<User> GetAdulthood(IEnumerable<User> users)
    {
        return users.Where(user => user.Age >= 18).Where(user=> user.Name.StartsWith("Ма"));
    }
}
class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}