using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var employees = GetEmployeesFromInput();
        var dictionary = DictionaryExtension.MyToDictionary(employees);
        foreach (var keyValuePair in dictionary)
        {
            Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value.Name}");
        }
    }

    static IEnumerable<Employee> GetEmployeesFromInput()
    {
        int n = 6;
        return new List<Employee>
     {
         new Employee (1, "Василий"),
         new Employee (2, "Иван"),
         new Employee (3, "Петр"),
         new Employee (4, "Семен"),
         new Employee (5, "Валерий"),
         new Employee (6, "Николай")
   };
    }
}
public class Employee
{
    public int Id { get; }
    public string Name { get; }
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}