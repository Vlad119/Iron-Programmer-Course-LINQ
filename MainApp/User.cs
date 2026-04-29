public class User
{
    public string Name { get; }
    public string Nickname { get; }
    public int Age { get; }

    public User(string name, string nickname, int age)
    {
        Name = name;
        Nickname = nickname;
        Age = age;
    }
}