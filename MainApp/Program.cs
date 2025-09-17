using System;
using System.Collections.Generic;

class Program
{

    static int n = 5;
    static IEnumerable<int> Numbers
    {
        get
        {
            int def = n;
            while (n != 0)
            {
                yield return n--;
            }
            while (n <= def)
            {
                yield return n++;
            }
        }
    }


    static void Main()
    {

        foreach (var number in Numbers)
        {
            Console.WriteLine(number);
        }
    }
}
