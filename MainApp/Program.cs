using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3 };
        // Шаг 1: Объявляем запрос
        var query = numbers.Where(n =>
        {
            Console.WriteLine("Проверяю число " + n);
            return n > 1;
        });

        Console.WriteLine("Запрос создан.");

        // Шаг 2: Меняем коллекцию
        numbers.Add(4);
        numbers.Add(5);

        // Шаг 3: Начинаем перебирать
        foreach (var q in query)
        {
            Console.WriteLine("Результат: " + q);
        }
    }
}
