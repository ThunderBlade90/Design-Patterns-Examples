using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Wypis : IVisitor
    {
        public void Visit(ChoryNaGlowe p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Do domu!");
        }
        public void Visit(ChoryNaZoladek p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Do domu, ale stosować dietę");
        }
        public void Visit(ChoryNaNoge p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Należy przewieźć do domu");
        }
    }
}
