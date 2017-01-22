using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tworzymy prototypy i ustalamy ich stan
            Scooter prototypeScooter = new Scooter();
            prototypeScooter.Name = "Black Scooter";

            Car prototypeCar = new Car();
            prototypeCar.Number = 55;

            Truck prototypeTruck = new Truck();
            prototypeTruck.Label = "BR332323";

            //Tworzymy sklonowane produkty
            Scooter[] scooters = new Scooter[10];
            for (int i = 0; i < scooters.Length; i++)
            {
                scooters[i] = prototypeScooter.Clone() as Scooter;
                
                if (prototypeScooter.Name == scooters[i].Name)
                {
                    Console.WriteLine("Copied scooter name and prototype scooter name are equal");
                }
            }

            Console.WriteLine();

            Car[] cars = new Car[10];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = prototypeCar.Clone() as Car;

                if (prototypeCar.Number == cars[i].Number)
                {
                    Console.WriteLine("Copied car number and prototype car number are equal");
                }
            }

            Console.WriteLine();

            Truck[] trucks = new Truck[10];
            for (int i = 0; i < trucks.Length; i++)
            {
                trucks[i] = prototypeTruck.Clone() as Truck;

                if (prototypeTruck.Label == trucks[i].Label)
                {
                    Console.WriteLine("Copied truck label and prototype truck label are equal");
                }
            }

            Console.ReadKey();
        }
    }
}
