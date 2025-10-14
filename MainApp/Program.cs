using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var retires = new List<List<Retiree>>
 {  
     // первое отделение
     new List<Retiree>
     {
         new Retiree("Иванов", 64, false),
         new Retiree("Петров", 65, false),
         new Retiree("Сидоров", 66, true)
     },

     //второе отделение
     new List<Retiree>
     {
         new Retiree("Пушкин", 72, true),
         new Retiree("Лермонтов", 66, false),
         new Retiree("Крылов", 89, true)
     },

     //третье отделение
     new List<Retiree>
     {
         new Retiree("Кипелов", 65, false),
         new Retiree("Цой", 62, true),
         new Retiree("Высоцкий", 86, true)
     }
 };

        var result = retires.SelectMany((list, index) =>
        list.Select((pensioner) =>
        pensioner.LaborVeteran? $"Пенсионер {pensioner.Surname} из {index + 1} отделения получит прибавку к пенсии в размере {pensioner.Age + 1500} рублей"
        :$"Пенсионер {pensioner.Surname} из {index + 1} отделения получит прибавку к пенсии в размере {pensioner.Age + 500} рублей"));

        foreach (var person in result)
        {
            Console.WriteLine(person);
        }
    }
}

class Retiree
{
    //Фамилия пенсионера
    public string Surname { get; set; }
    //Возраст пенсионера
    public int Age { get; set; }
    //Флаг, указывающий является ли пенсионер ветераном труда
    public bool LaborVeteran { get; set; }
    public Retiree(string surname, int age, bool laborVeteran)
    {
        Surname = surname;
        Age = age;
        LaborVeteran = laborVeteran;
    }
}
