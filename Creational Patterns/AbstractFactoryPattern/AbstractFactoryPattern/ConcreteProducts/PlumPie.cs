using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PlumPie : ITartPie
    {
        private double _price;
    
        public PlumPie(double price)
        {
            this._price = price;
        }

        #region ITartPie Members

        public string Description()
        {
            return "Tart Plum Pie";
        }
    
        public double Price
        {
            get { return this._price; }
        }
    
        #endregion
    }
}
