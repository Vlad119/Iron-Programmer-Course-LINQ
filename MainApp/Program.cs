using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        //var num = int.Parse(Console.ReadLine());
        var users = new List<User>
    {
        new User ("Анна", "Scorpion", 22),
        new User ("Николай", "TheDestroyer817", 28),
        new User ("Сергей", "RainingMan", 35),
        new User ("Андрей", "Mr.A", 19)
    };

        var result = GetShortestNicknameLength(users);
        Console.WriteLine(result);
    }

    static int GetShortestNicknameLength(IEnumerable<User> users)
    {
        return users.Min(x => x.Nickname.Length);
    }
}
public class User
{
    public string Name { get; set; }
    public string Nickname { get; set; }
    public int Age { get; set; }

    public User(string name, string nickname, int age)
    {
        Name = name;
        Nickname = nickname;
        Age = age;
    }
}