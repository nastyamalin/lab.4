
namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment();
            apartment.AddAppliance(new KitchenAppliance("Oven", 1500));
            apartment.AddAppliance(new KitchenAppliance("Microwave", 1000));
            apartment.AddAppliance(new KitchenAppliance("Toaster", 800));
            apartment.AddAppliance(new LivingRoomAppliance("TV", 150));
            apartment.AddAppliance(new LivingRoomAppliance("Lamp", 30));
            apartment.AddAppliance(new LivingRoomAppliance("Stereo", 300));
            apartment.AddAppliance(new BathroomAppliance("Manual washing machine", 300));
            apartment.AddAppliance(new BathroomAppliance("Drying", 300));
            apartment.AddAppliance(new BathroomAppliance("Hair dryer", 1200));
            apartment.AddAppliance(new BedroomAppliance("Laptop", 50));
            apartment.AddAppliance(new BedroomAppliance("Electric clock", 10));
            apartment.AddAppliance(new BedroomAppliance("Electric blanket", 350));

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Show sorting by power");
            Console.WriteLine("2. Find appliances by power range");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    apartment.SortAppliancesByPower();
                    break;
                case 2:
                    Console.WriteLine("Enter min power:");
                    int minPower = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter max power:");
                    int maxPower = int.Parse(Console.ReadLine());
                    apartment.FindAppliancesInRange(minPower, maxPower);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}