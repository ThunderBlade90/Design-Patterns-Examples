using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeDrink md = new Tea();
            md.Run();
            Console.WriteLine();

            md = new Coffee();
            md.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
