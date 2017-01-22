using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategy strategy = null;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double Calculate(double a, double b)
        {
            return this.strategy.Calculate(a, b);
        }
    }
}
