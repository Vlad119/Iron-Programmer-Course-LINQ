using System.Collections.Generic;
using System.Linq;

static class ThenByExtension
{
    public static IEnumerable<User> MyOrderByThenBy(this IEnumerable<User> users)
    {
        var usersOrderedByNames = users.OrderBy(user => user.Name).ToArray();
        for (int i = usersOrderedByNames.Length - 1; i > 0; i--) 
        {
            bool flag = false; 
            for (int j = 0; j < i; j++)
            {
                if (usersOrderedByNames[j].Name == usersOrderedByNames[j + 1].Name)
                {
                    if (usersOrderedByNames[j].Age > usersOrderedByNames[j + 1].Age)
                    {
                        (usersOrderedByNames[j], usersOrderedByNames[j + 1]) =
                            (usersOrderedByNames[j + 1], usersOrderedByNames[j]);
                        flag = true;
                    }
                }
            }
            if (flag == false)
            {
                return usersOrderedByNames; 
            }
        }
        return usersOrderedByNames;
    }
}

