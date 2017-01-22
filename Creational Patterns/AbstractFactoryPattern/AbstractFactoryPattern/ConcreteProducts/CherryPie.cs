using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CherryPie : IFruitPie
    {
        private double _price;
    
        public CherryPie(double price)
        {
            this._price = price;
        }

        #region IFruitPie Members
    
        public string Description()
        {
            return "Pie with fresh Cherries";
        }
    
        public double Price
        {
            get { return _price; }
        }
    
        #endregion
    }
}
