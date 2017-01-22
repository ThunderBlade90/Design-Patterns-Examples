using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface IKomponent
    {
        int Cena { get; set; }
        string NazwaWyswietlana { get; set; }

        void Dodaj(IKomponent ob);
        void Usun(IKomponent ob);
        void Wyswietl(int przesuniecie);
    }
}
