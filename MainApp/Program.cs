using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(';'); 
        var searchString = Console.ReadLine();
        var users = input.Select(userData => userData.Split(", "))
        .Select(x => new User(x[0], x[1], int.Parse(x[2])));
        var result = users.LastOrDefault(user => user.Nickname.ToLower().Contains(searchString.ToLower()));
        Console.WriteLine(result);
    }
}

