using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int steps = 0;
        while (number != 6174)
        {
            string numStr = number.ToString("D4");
            var descendingDigits = numStr.Select(c => c).OrderByDescending(c => c);
            string descending = new string(descendingDigits.ToArray());
            var ascendingDigits = numStr.Select(c => c).OrderBy(c => c);
            string ascending = new string(ascendingDigits.ToArray());
            int min = int.Parse(ascending);
            int max = int.Parse(descending);
            number = max - min;
            steps++;
        }
        Console.WriteLine(steps);
    }
}