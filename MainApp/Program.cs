using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new string[5] { "Иосиф 26", "Алексей 33", "Николай 32", "Наталья 31", "Роксана 30" };
        var users = GetUsers(list);
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Name} {user.Age}");
        }
    }

    static IEnumerable<User> GetUsers(string[] input)
    {
        //var users = new List<User>();
        //foreach (var user in input)
        //{
        //    var u = user.Split(' ');
        //    users.Add(new User(u[0], int.Parse(u[1])));
        //}
        //return users;
        return input.Select(u => u.Split()).Select(x => new User(x[0], int.Parse(x[1])));
    }
}
class User
{
    public string Name { get; set; }

    public int Age { get; set; }
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}