﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DivisionStrategy : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }
}
