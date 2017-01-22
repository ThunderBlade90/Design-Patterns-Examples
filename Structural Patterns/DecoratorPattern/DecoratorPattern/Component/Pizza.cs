using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public abstract double CalculateCost();

        public abstract string GetName();
    }
}
