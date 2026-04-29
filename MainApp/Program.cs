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
        while ((line = Console.ReadLine()) != "")
        {
            if (line == "Недавно решено задач:") continue;
            var parts = line.Substring(1).Split(' ', 2);
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
        var taskList = tasks.Select(x => new { Name = x.Key, Count = x.Value, Order = order[x.Key] }).ToList();
        taskList.Sort((a, b) => {
            int countComparison = b.Count.CompareTo(a.Count);
            if (countComparison != 0) return countComparison;
            return a.Order.CompareTo(b.Order);
        });
        Console.WriteLine("Кол-во за день:");
        for (int i = 0; i < taskList.Count; i++)
        {
            var item = taskList[i];
            Console.WriteLine($"{i + 1} {item.Name} {item.Count}");
        }
    }
}