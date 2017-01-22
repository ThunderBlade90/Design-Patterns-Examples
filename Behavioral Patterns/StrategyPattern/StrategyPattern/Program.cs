using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 2;
            Operation operation = Operation.Addition;
            Context context = null;

            switch (operation)
            {
                case Operation.Addition:
                    context = new Context(new AdditionStrategy());
                    break;
                case Operation.Subtraction:
                    context = new Context(new SubtractionStrategy());
                    break;
                case Operation.Multiplication:
                    context = new Context(new MultiplicationStrategy());
                    break;
                case Operation.Division:
                    context = new Context(new DivisionStrategy());
                    break;
            }

            Console.WriteLine(context.Calculate(a, b));
            Console.ReadKey();
        }
    }
}
