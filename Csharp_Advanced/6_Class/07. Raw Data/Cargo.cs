using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData;

public class Cargo
{
    public Cargo(int weight, string cargo)
    {
        Type = cargo;
        Weight = weight;
    }

    public string Type { get; set; }
    public int Weight { get; set; }

}
