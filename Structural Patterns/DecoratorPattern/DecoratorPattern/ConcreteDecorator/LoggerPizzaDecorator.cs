using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LoggerPizzaDecorator : PizzaDecorator
    {
        public LoggerPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            Console.WriteLine("Before CalculateCost");
            var result = base.CalculateCost();
            Console.WriteLine("After CalculateCost " + result);
            return result;
        }

        public override string GetName()
        {
            Console.WriteLine("Before GetName");
            var name = base.GetName();
            Console.WriteLine("After GetName : " + name);
            return name;
        }
    }
}
