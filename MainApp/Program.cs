using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var husbants = new List<Husband>
    {
        new Husband { Name = "Петров", Age = 27, Benevolence = true, Decency = true, Humor = true, Masculinity = true, Intelligence = false },
        new Husband { Name = "Петр", Age = 32, Benevolence = true, Decency = true, Humor = true, Masculinity = true, Intelligence = false },
        new Husband { Name = "Жан-Клод", Age = 46, Benevolence = true, Decency = true, Humor = true, Masculinity = true, Intelligence = false }
    };

        var firstPatient = GetHusband(husbants);
        Console.WriteLine(firstPatient);
    }

    static string GetHusband(List<Husband> husbands)
    {
        try
        {
            var result = husbands.SingleOrDefault(x => x.Humor && x.Masculinity && x.Intelligence && x.Decency && x.Benevolence);
            return result?.Name ?? "Еще не время";
        }
        catch
        {
            return "Выбор огромен";
        }
    }
}

class Husband
{
    // Имя 
    public string Name { get; set; }
    // Возраст
    public int Age { get; set; }
    // Доброта
    public bool Benevolence { get; set; }
    // Порядочность
    public bool Decency { get; set; }
    // Юмор
    public bool Humor { get; set; }
    // Мужественность
    public bool Masculinity { get; set; }
    // Интеллект
    public bool Intelligence { get; set; }

}