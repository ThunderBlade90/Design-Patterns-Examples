using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Miauuuu!");
        }
    }
}
