using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var patients = new List<Patient>
    {
        new Patient {Surname = "Петров", Privilege = false },
        new Patient {Surname = "Иванов", Privilege = false }
    };

        var firstPatient = TryGetNextPatient(patients);
        Console.WriteLine(firstPatient);
    }

    static string TryGetNextPatient(List<Patient> patients)
    {
        var patient = patients.FirstOrDefault(x => x.Privilege) ?? patients.FirstOrDefault();
        return patient?.Surname ?? "Пациентов в очереди нет";
    }

}
