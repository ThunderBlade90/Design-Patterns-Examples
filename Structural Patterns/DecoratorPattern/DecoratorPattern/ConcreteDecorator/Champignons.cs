using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ChampignonsDecorator : PizzaDecorator
    {
        public ChampignonsDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 6.15;
        }

        public override string GetName()
        {
            return base.GetName() + ", Champignons";
        }
    }
}
