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
//команда 1
                new string[]{"Мохаммед Салах", "Паоло Мальдини", "Франц Беккенбауэр", "Мишель Платини"},
//команда 2
                new string[]{"Йохан Кройф", "Лев Яшин", "Дэвид Бэкхем", "Диего Марадона"} 
//команда 3
            };

        string l = Console.ReadLine();

        var result = teams.SelectMany((team, teamIndex) =>
        team.Where(player =>
        player.Split(' ').Last().ToLower().StartsWith(l.ToLower()))
        .Select(player => new { Name = player, TeamNumber = teamIndex + 1 }));
        foreach (var player in result)
        {
            Console.WriteLine($"Команда номер {player.TeamNumber}, {player.Name}");
        }
    }
}
