using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        var rectagles = new List<Rectangle>
    {
        new Rectangle(1, 9),
        new Rectangle(2, 8),
        new Rectangle(3 , 7),
        new Rectangle(4 , 6),
        new Rectangle(5 , 5)
    };
        var result = SortByArea(rectagles);
        foreach (var rectangle in result)
        {
            Console.WriteLine($"{rectangle.Width} {rectangle.Height}");
        }
    }

    static IEnumerable<Rectangle> SortByArea(IEnumerable<Rectangle> rectangles)
    {
        return rectangles.OrderBy(x => x.Width * x.Height);
    }
}
