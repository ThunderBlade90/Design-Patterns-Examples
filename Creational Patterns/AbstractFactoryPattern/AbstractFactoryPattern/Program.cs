using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new KrakowBakery();
            IFruitPie FruitPie = bakery.CreateFruitPie();
            Console.WriteLine(FruitPie.Description());
            ITartPie TartPie = bakery.CreateTartPie();
            Console.WriteLine(TartPie.Description());
            
            Console.WriteLine();
            
            bakery = new WarsawBakery();
            FruitPie = bakery.CreateFruitPie();
            Console.WriteLine(FruitPie.Description());
            TartPie = bakery.CreateTartPie();
            Console.WriteLine(TartPie.Description());

            Console.ReadLine();
        }
    }
}
