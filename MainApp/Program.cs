using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var powerOutlets = new List<PowerOutlet>()
{
    new PowerOutlet{Name = "Legrand0", Grounding = true},
    new PowerOutlet{Name = "TDM0", Grounding = false},
    new PowerOutlet{Name = "IEK0", Grounding = true},
    new PowerOutlet{Name = "Schneider0", Grounding = false},
    new PowerOutlet{Name = "Legrand1", Grounding = true},
    new PowerOutlet{Name = "TDM1", Grounding = false},
    new PowerOutlet{Name = "IEK1", Grounding = true},
    new PowerOutlet{Name = "Schneider1", Grounding = false}
};
    }

    static int GetLengthWire(List<PowerOutlet> powerOutlets)
    {
        return powerOutlets.Count(x => x.Grounding) * 5;
    }

}

class PowerOutlet
{
    //Название розетки
    public string Name { get; set; }
    //Флаг указывающий с заземлением ли розетка
    public bool Grounding { get; set; }
}