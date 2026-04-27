public class User
{
    public string Name { get; }
    public int Age { get; }
    public int FriendsCount { get; }
    public User(string name, int age, int friendsCount)
    {
        Name = name;
        Age = age;
        FriendsCount = friendsCount;
    }
}
