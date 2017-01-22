using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Leczenie : IVisitor
    {

        public void Visit(ChoryNaGlowe p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Stosuję aspirynę");
        }
        
        public void Visit(ChoryNaZoladek p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Stosuję węgiel");
        }
        
        public void Visit(ChoryNaNoge p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Zakładam gips");
        }
    }
}
