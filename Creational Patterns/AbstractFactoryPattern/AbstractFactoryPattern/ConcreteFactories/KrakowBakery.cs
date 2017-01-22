using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class KrakowBakery : Bakery
    {
        public override IFruitPie CreateFruitPie()
        {
            return new ApplePie(23.50);
        }
    
        public override ITartPie CreateTartPie()
        {
            return new PlumPie(28.40);
        }
    }
}
