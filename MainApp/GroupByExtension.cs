using System.Collections.Generic;
using System.Linq;

public static class GroupByExtension
{
    public static IEnumerable<GroupStudents> GroupByAge(this IEnumerable<Student> students)
    {
        var result = new List<GroupStudents>();
        var ages = students.Select(s => s.Age).Distinct();
        foreach (var age in ages)
        {
            var sortedStudents = students.Where(s => s.Age == age);
            result.Add(new GroupStudents(age, sortedStudents));
        }
        return result;
    }
}
