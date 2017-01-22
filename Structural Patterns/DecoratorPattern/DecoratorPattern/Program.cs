using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BootStraper.Boot();

            Console.ReadKey();

            //Pizza largePizza = new LargePizza();

            //largePizza = new CheeseDecorator(largePizza);
            //largePizza = new HamDecorator(largePizza);
            //largePizza = new ChampignonsDecorator(largePizza);

            //Console.WriteLine("{0:C2}", largePizza.CalculateCost());
            //Console.WriteLine(largePizza.GetName());

            //Console.ReadKey();
        }
    }
}
