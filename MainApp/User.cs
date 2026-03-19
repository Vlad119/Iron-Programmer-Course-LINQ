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

    public override string ToString()
    {
        return $"{Name}, {Nickname}, {Age}";
    }
}