using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class StrukturaPacjentow
    {
        private List<Pacjent> _pacjenci = new List<Pacjent>();

        public void Dolacz(Pacjent pacjent)
        {
            _pacjenci.Add(pacjent);
        }

        public void Odlacz(Pacjent pacjent)
        {
            _pacjenci.Remove(pacjent);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Pacjent pacjent in _pacjenci)
            {
                pacjent.Accept(visitor);
            }
        }
    }
}
