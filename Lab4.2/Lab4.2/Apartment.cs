using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Apartment
    {
        private List<ElectricalAppliance> appliances = new List<ElectricalAppliance>();

        public void AddAppliance(ElectricalAppliance appliance)
        {
            appliances.Add(appliance);
        }

        public void SortAppliancesByPower()
        {
            var sortedAppliances = appliances.OrderBy(appliance => appliance.Power);
            Console.WriteLine("Appliances sorted by power:");
            foreach (var appliance in sortedAppliances)
            {
                Console.WriteLine($"{appliance.Name}: {appliance.Power} watts");
            }
        }

        public void FindAppliancesInRange(int minPower, int maxPower)
        {
            var foundAppliances = appliances.Where(appliance => appliance.Power >= minPower && appliance.Power <= maxPower);
            Console.WriteLine($"Appliances with power in the range {minPower}-{maxPower} watts:");
            foreach (var appliance in foundAppliances)
            {
                Console.WriteLine($"{appliance.Name}: {appliance.Power} watts");
            }
        }
    }
}
