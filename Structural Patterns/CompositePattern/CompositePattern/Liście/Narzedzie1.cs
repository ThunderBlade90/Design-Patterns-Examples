using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Narzedzie1 : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Narzedzie1(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 30;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }
}
