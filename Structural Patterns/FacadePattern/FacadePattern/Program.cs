using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fasada ob = new Fasada();
            ob.ObliczPierWielomianu(2, 6, 4);

            Console.ReadLine();
        }
    }
}
