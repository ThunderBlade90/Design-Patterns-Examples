using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PizzaDecorator : Pizza
    {

        //obiekt który będzie dekorowany
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetName()
        {
            return _pizza.GetName();
        }
    }

}
