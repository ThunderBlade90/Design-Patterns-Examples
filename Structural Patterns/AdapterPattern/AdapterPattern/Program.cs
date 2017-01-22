using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter client = new Adapter();
            client.methodA(); // wyswietli "metoda B"

            Console.ReadLine();
        }
    }
}
