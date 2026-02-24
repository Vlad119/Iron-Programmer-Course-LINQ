internal class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }
    public int Population { get; set; }

    public override string ToString()
    {
        return $"{Name} {Population}";
    }
}