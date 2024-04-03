using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class ElectricalAppliance
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public ElectricalAppliance(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public void PlugIn()
        {
            Console.WriteLine($"{Name} is plugged in.");
        }
    }
}
