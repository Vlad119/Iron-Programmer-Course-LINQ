namespace LINQ
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Rating { get; set; }

        public Item(string name, string type, int cost, int rating)
        {
            Name = name;
            Type = type;
            Cost = cost;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name}: {Cost}, {Rating}";
        }
    }
}