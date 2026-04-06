using System.Collections.Generic;
using System.Linq;

static class DistinctExtension
{
    public static IEnumerable<Student> DistinctAdultStudents(this IEnumerable<Student> students)
    {
        return students.Where(s=>s.Age>=18).Distinct(new StudentIEqualityComparer());
    }
}
