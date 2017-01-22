using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ApplePie : IFruitPie
    {
        private double _price;
    
        public ApplePie(double price)
        {
            this._price = price;
        }

        #region IFruitPie Members
    
        public string Description()
        {
            return "Pie with fresh Apples";
        }
    
        public double Price
        {
            get { return _price; }
        }
    
        #endregion
    }
}
