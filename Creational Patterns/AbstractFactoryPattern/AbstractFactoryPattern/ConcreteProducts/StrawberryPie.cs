using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class StrawberryPie : ITartPie
    {
        private double _price;
    
        public StrawberryPie(double price)
        {
            this._price = price;
        }

        #region ITartPie Members

        public string Description()
        {
            return "Tart Strawberry Pie";
        }
    
        public double Price
        {
            get { return this._price; }
        }
    
        #endregion
    }
}
