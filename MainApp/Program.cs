using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var tasks = new Dictionary<string, int>();
        var order = new Dictionary<string, int>();
        int originalIndex = 0;
        string line;
        int blockCount = 0;
        while (blockCount <= 48 && !string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            if (line == "Недавно решено задач:")
            {
                blockCount++;
                continue;
            }
            var parts = line.Substring(1).Split(' ', 2);
            if (parts.Length < 2)
            {
                continue;
            }
            int solved = int.Parse(parts[0]);
            string name = parts[1];
            if (!order.ContainsKey(name))
            {
                order[name] = originalIndex++;
            }
            if (tasks.ContainsKey(name))
            {
                tasks[name] += solved;
            }
            else
            {
                tasks[name] = solved;
            }
        }
        var sortedResults = tasks.OrderByDescending(x => x.Value)
            .ThenBy(x => order[x.Key]).ToList();
        Console.WriteLine("Кол-во за день:");
        for (int i = 0; i < sortedResults.Count; i++)
        {
            var item = sortedResults[i];
            Console.WriteLine($"{i + 1} {item.Key} {item.Value}");
        }
    }
}