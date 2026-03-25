using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        var peoples = new List<People>();
        int counter = 0;
        while (counter != peopleCount)
        {
            var input = Console.ReadLine().Split(", ");
            string name = input[0];
            bool aliby = bool.Parse(input[1]);
            bool motive = bool.Parse(input[2]);
            peoples.Add(new People(name, aliby, motive));
            counter++;
        }
        var filtered = peoples.Where(p => !p.Aliby && p.Motive).ToList();
        var result = filtered.Count == 1 ? filtered[0] : null;
        Console.WriteLine(result?.Name ?? "Тупик");
    }
}

public class People
{
    public string Name { get; set; }
    public bool Aliby { get; set; }
    public bool Motive { get; set; }

    public People(string name, bool aliby, bool motive)
    {
        Name = name;
        Aliby = aliby;
        Motive = motive;
    }

    public override string ToString()
    {
        return Name;
    }
}
