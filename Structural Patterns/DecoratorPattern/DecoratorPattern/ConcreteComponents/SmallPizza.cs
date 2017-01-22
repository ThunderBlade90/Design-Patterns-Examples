using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SmallPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 12.00;
        }

        public override string GetName()
        {
            return "Small Pizza";
        }
    }
}
