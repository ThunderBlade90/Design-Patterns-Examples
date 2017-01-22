using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizyta pacjent1 = new Wizyta("Pacjent Adam");
            pacjent1.Dodaj(new Przeglad("Przegląd"));

            UsuniecieUbytku usuniecieUbytku = new UsuniecieUbytku("Usunięcie ubytku");
            usuniecieUbytku.Dodaj(new Narzedzie1("Użycie narzędzia 1"));
            usuniecieUbytku.Dodaj(new Plombowanie("Plombowanie"));
            usuniecieUbytku.Dodaj(new Szlifowanie("Szlifowanie"));

            pacjent1.Dodaj(usuniecieUbytku);

            pacjent1.Wyswietl(2);

            Console.ReadLine();
        }
    }
}
