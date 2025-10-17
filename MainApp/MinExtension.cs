using System;
using System.Collections.Generic;

public static class MinExtension
{
    public static int MyMin(this IEnumerable<int> numbersSource)
    {
        using (var numbers = numbersSource.GetEnumerator()) // using для освобождения ресурсов
        {
            if (!numbers.MoveNext()) // Проверяем, есть ли элементы
            {
                throw new InvalidOperationException("Коллекция пуста");
            }
            int min = numbers.Current;
            int current;
            while (numbers.MoveNext())
            {
                current = numbers.Current;
                if (current < min) min = current;
            }
            return min;
        }
    }
}
