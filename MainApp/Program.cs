using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>
            {
                new User("Алина", 108, true),
                new User("Света", 30, false),
                new User("Карина", 30, true)
            };

        var result = GetUser(users);
        foreach (User user in result)
        {
            Console.WriteLine(user.Name);
        }

        static IEnumerable<User> GetUser(IEnumerable<User> users)
        {
            return users.Where(u => u.SchoolNumber == 30 || u.SchoolNumber == 108).Where(u=>u.LikeOrMessages);
        }
    }
}
class User
{
    public User(string name, int schoolNumber, bool likeOrMessages)
    {
        Name = name;
        SchoolNumber = schoolNumber;
        LikeOrMessages = likeOrMessages;
    }

    //Имя пользователя
    public string Name { get; set; }

    //Номер школы
    public int SchoolNumber { get; set; }

    //Флаг указывающий отпралял ли пользователь сообщения или лайки
    public bool LikeOrMessages { get; set; }

}
