using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Pacjent
    {
        protected string _name;
        public Pacjent(string name)
        {
            _name = name;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
