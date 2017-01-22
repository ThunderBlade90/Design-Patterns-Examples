using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    class MathProxy : IMath
    {
        private Math _math;

        public double Add(double x, double y)
        {
            // Use 'lazy initialization'
            if (_math == null)
            {
                _math = new Math();
            }

            return _math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            // Use 'lazy initialization'
            if (_math == null)
            {
                _math = new Math();
            }

            return _math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            // Use 'lazy initialization'
            if (_math == null)
            {
                _math = new Math();
            }

            return _math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            // Use 'lazy initialization'
            if (_math == null)
            {
                _math = new Math();
            }

            return _math.Div(x, y);
        }
    }
}
