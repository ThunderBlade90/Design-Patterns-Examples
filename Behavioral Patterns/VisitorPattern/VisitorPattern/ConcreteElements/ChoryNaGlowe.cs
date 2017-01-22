using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ChoryNaGlowe : Pacjent
    {
        private static string opis = "Chory na głowę";
        public ChoryNaGlowe(string name) : base(name)
        {

        }
        public string toString() { return base._name + " " + opis; }
      
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
      
    }
}
