using System.Collections.Generic;
public static class SumExtension
{
    public static decimal MySum2(this IEnumerable<Phone> phones)
    {
        decimal sum = 0;
        foreach (var phone in phones)
        {
            sum += phone.Cost;
        }
        return sum;
    }
}
