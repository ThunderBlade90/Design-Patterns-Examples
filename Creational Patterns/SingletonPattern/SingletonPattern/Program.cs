using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //utwórzmy dwa obiekty klasy Singleton
            Singleton o1 = Singleton.createObject();
            Singleton o2 = Singleton.createObject();

            //sprawdzamy czy referencje wskazują na ten sam obiekt
            if (o1 == o2)
            {
                Console.WriteLine("Identyczne");
            }
            else
            {
                Console.WriteLine("Różne");
            }

            Console.ReadKey();
        }
    }
}
