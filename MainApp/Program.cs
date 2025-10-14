using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<string[]> teams = new List<string[]>
            {
                new string[]{"Лионель Месси", "Криштиану Роналду", "Златан Ибрагимович", "Роберт Левандовский"},
                new string[]{"Мохаммед Салах", "Паоло Мальдини", "Франц Беккенбауэр", "Мишель Платини"},
                new string[]{"Йохан Кройф", "Лев Яшин", "Дэвид Бэкхем", "Диего Марадона"}
            };

        int n = Convert.ToInt32(Console.ReadLine());

        var result = teams.SelectMany((team, teamIndex) =>
        team.Select((player, playerIndex) =>
        $"{player} играет в команде №{teamIndex + 1} под номером {playerIndex + n}"));

        foreach (var playerInfo in result)
        {
            Console.WriteLine(playerInfo);
        }
    }
}
