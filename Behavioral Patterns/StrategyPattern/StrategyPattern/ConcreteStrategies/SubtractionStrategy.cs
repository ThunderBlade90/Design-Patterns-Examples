using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SubtractionStrategy : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}
