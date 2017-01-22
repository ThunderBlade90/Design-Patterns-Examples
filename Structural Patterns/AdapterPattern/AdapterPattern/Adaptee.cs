using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adaptee
    {
        public void methodB()
        {
            Console.WriteLine("Metoda B");
        }
    }
}
