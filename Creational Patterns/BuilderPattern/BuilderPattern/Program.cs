using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Kid kid = new Kid();
            kid.Name = "Elizabeth";

            //Elizabeth use Monkey mold to make a monkey
            Console.WriteLine("{0} start making a monkey", kid.Name);
            AnimalBuilder monkeyBuilder = new MonkeyBuilder();
            kid.MakeAnimal(monkeyBuilder);
            monkeyBuilder.Animal.ShowMe();

            //Elizabeth use Kitten mold to make a kitten
            Console.WriteLine("{0} start making a kitten", kid.Name);
            AnimalBuilder kittenBuilder = new KittenBuilder();
            kid.MakeAnimal(kittenBuilder);
            kittenBuilder.Animal.ShowMe();

            Console.ReadLine();
        }
    }
}
