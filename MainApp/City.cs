public class City
{
    public string Name { get; set; }
    public int CitizensCount { get; set; }

    public City(string name, int citizensCount)
    {
        CitizensCount = citizensCount;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}, {CitizensCount}";
    }
}