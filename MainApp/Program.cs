using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            var items = new List<Item>
            {
                new Item("22032 Fillips", "Телевизор", 2500, 4),
                new Item("22W37 ShangTsung", "Телевизор", 3000, 5),
                new Item("1005L 3G", "Телевизор", 4000, 3),
                new Item("15Q BiQ", "Телевизор", 5000, 4),

                new Item("7700 Soni", "Телефон", 2500, 5),
                new Item("10X Epple", "Телефон", 70000, 5),
                new Item("MI5 Ksaome", "Телефон", 5100, 4),
                new Item("2AP7 ShangTsung", "Телефон", 8900, 4),

                new Item("1121 Cefal", "Пылесос", 5000, 4),
                new Item("VC53 3G", "Пылесос", 4500, 5),
                new Item("F214 Borsch", "Пылесос", 6000, 5),
                new Item("RV32 Bredmond", "Пылесос", 7800, 3),

                new Item("2H12 Hawaii", "Ноутбук", 25000, 5),
                new Item("HK23 Oasis", "Ноутбук", 20000, 4),
                new Item("P92 HB", "Ноутбук", 21000, 5),
                new Item("VO2219 Lenoblo", "Ноутбук", 27000, 3),
            };

            string type = Console.ReadLine();
            string sorting = Console.ReadLine();
            var sorted = Sort(items, type, sorting);
            Console.WriteLine(string.Join("\n", sorted));

        }
        static IEnumerable<Item> Sort(IEnumerable<Item> items, string type, string sorting)
        {
            var result = items.Where(x => x.Type == type);
            switch (sorting)
            {
                case "1": { return result.OrderBy(x => x.Cost / x.Rating); }
                case "2": { return result.OrderBy(x => x.Cost); }
                case "3": { return result.OrderByDescending(x => x.Cost); }
                case "4": { return result.OrderByDescending(x => x.Rating); }
            }
            return null;
        }

    }
}