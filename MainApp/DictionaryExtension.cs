using System;
using System.Collections.Generic;

public static class DictionaryExtension
{
    public static Dictionary<int, Employee> MyToDictionary(this IEnumerable<Employee> employees)
    {
        var result = new Dictionary<int, Employee>();
        foreach (var employee in employees)
        {
            if (result.ContainsKey(employee.Id))
            throw new Exception($"Ключ {employee.Id} уже существует.");
            result.Add(employee.Id, employee);
        }
        return result;
    }
}
