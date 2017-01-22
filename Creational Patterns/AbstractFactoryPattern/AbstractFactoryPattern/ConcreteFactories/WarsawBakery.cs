using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WarsawBakery : Bakery
    {
        public override IFruitPie CreateFruitPie()
        {
            return new CherryPie(33.68);
        }
    
        public override ITartPie CreateTartPie()
        {
            return new StrawberryPie(39.40);
        }
    }
}
