using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var files = new List<File>
    {
        new File
        (
            new List<string>
            {
                "1",
                "слово",
                "-2",
                "-c"
            }
            ),
        new File
        (
            new List<string>
            {
                "83",
                " ",
                "aaaaa",
                "quququq"
            }
            ),

        new File
        (
            new List<string>
            {
                "90",
                "slskdjf23l",
                "13",
                "n"
            }
            )
    };
        var inputNumbers = GetNumbers(files);

        Console.WriteLine(string.Join(" ", inputNumbers));
    }

    static IEnumerable<string> GetNumbers(List<File> files)
    {
        return files
        .SelectMany(f => f.Rows)
        .Where(f => int.TryParse(f, out int result));
    }
}
public class File
{
    public List<string> Rows { get; set; }

    public File(List<string> rows)
    {
        Rows = rows;
    }
}