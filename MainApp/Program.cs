using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var car1 = new CarMuffler() { CarBrand = "MERCEDES", YearRelease = 2005, Cost = 18000 };
        var car2 = new CarMuffler() { CarBrand = "NISSAN Terrano 2", YearRelease = 2007, Cost = 17500 };
        var car3 = new CarMuffler() { CarBrand = "MITSUBISHI", YearRelease = 2007, Cost = 17000 };
        var car4 = new CarMuffler() { CarBrand = "NISSAN Terrano 2", YearRelease = 2006, Cost = 18000 };
        var car5 = new CarMuffler() { CarBrand = "NISSAN Terrano 2", YearRelease = 2007, Cost = 18000 };
        var car6 = new CarMuffler() { CarBrand = "NISSAN KADJAR", YearRelease = 2007, Cost = 18000 };
        var car7 = new CarMuffler() { CarBrand = "NISSAN Terrano", YearRelease = 2007, Cost = 18500 };
        var car8 = new CarMuffler() { CarBrand = "PEUGEOT", YearRelease = 2007, Cost = 17500 };
        var carSearch = GetMuffler(new[] { car1, car2, car3, car4, car5, car6, car7, car8 });
        foreach (var car in carSearch) Console.WriteLine(car.CarBrand);
    }

    static IEnumerable<CarMuffler> GetMuffler(IEnumerable<CarMuffler> mufflers)
    {
        return mufflers.Where(m => m.CarBrand == "NISSAN Terrano 2").Where(m => m.YearRelease == 2007).Where(m => m.Cost <= 18_000);
    }

}
class CarMuffler
{
    //Марка авто
    public string CarBrand { get; set; }

    //Год выпуска
    public int YearRelease { get; set; }

    //Стоимость глушителя
    public decimal Cost { get; set; }
}