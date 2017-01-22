using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ChoryNaNoge : Pacjent
    {
        private static string opis = "Chory na nogę";
        public ChoryNaNoge(string name) : base(name)
        {

        }
        public string toString() { return base._name + " " + opis; }


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
