using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var child1 = new Child() { FullName = "Александр", DiminutiveName = "Саня" };
        var child2 = new Child() { FullName = "Георгий", DiminutiveName = "Гоша" };
        var child3 = new Child() { FullName = "Елена", DiminutiveName = "Леночка" };
        var child4 = new Child() { FullName = "Константин", DiminutiveName = "Костик" };
        var child5 = new Child() { FullName = "Сергей", DiminutiveName = "Серёженька" };
        var shortNames = GetShortName(new[] { child1, child2, child3, child4, child5 });
        Console.WriteLine("Список имён, удовлетворяющих условию задачи:");
        foreach (var name in shortNames)
        {
            Console.WriteLine(name.FullName);
        }
    }

    static IEnumerable<Child> GetShortName(IEnumerable<Child> children)
    {
        return children.Where(c => c.FullName.Length >= c.DiminutiveName.Length);
    }
}
public class Child
{
    //полное имя
    public string FullName { get; set; }

    //уменьшительно-ласкательное имя
    public string DiminutiveName { get; set; }
}