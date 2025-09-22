using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = "1 2 3 4";
        var result = GetNumbers(numbers);
        Console.WriteLine(string.Join(' ', result));
    }

    //static int[] GetNumbers(string input)
    //{
    //    Делим строку по пробелам и получим массив строк
    //    var data = input.Split();
    //    Заведем НОВЫЙ массив чисел
    //    var numbers = new int[data.Length];
    //    Проходим по массиву строк
    //    for (int i = 0; i < data.Length; i++)
    //    {
    //        Конвертируем каждый строковый элемент в число
    //        var number = Convert.ToInt32(data[i]);

    //        Записываем в массив чисел
    //        numbers[i] = number;
    //    }
    //    return numbers;
    //}

    static int[] GetNumbers(string input)
    {
        return input.Split().Select(x=>Convert.ToInt32(x)).ToArray();
    }
}
