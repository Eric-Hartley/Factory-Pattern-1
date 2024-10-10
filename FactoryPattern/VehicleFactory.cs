using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many tires do you want on your vehicle?");
            Console.WriteLine("2 : Motorcycle");
            Console.WriteLine("4 : Car");
            Console.WriteLine("6 : Truck");

            var answer = Console.ReadLine();

            switch (int.Parse(answer))
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 6:
                    return new Truck();
                default:
                    return new Motorcycle();
            }
        }
    }
}
