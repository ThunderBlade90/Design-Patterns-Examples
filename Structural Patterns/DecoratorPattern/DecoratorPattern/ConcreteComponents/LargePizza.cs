using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LargePizza : Pizza
    {
        public override double CalculateCost()
        {
            return 50.00;
        }

        public override string GetName()
        {
            return "Large Pizza";
        }
    }
}
