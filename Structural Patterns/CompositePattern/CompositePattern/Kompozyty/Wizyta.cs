using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Wizyta : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }
        private List<IKomponent> _dzieci = new List<IKomponent>();

        public Wizyta(string nazwa)
        {
            NazwaWyswietlana = nazwa;
        }

        public void Dodaj(IKomponent ob)
        {
            _dzieci.Add(ob);
            Cena += ob.Cena;
        }

        public void Usun(IKomponent ob)
        {
            _dzieci.Remove(ob);
            Cena -= ob.Cena;
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));

            foreach (IKomponent ob in _dzieci)
            {
                ob.Wyswietl(przesuniecie + 2);
            }
        }
    }
}
