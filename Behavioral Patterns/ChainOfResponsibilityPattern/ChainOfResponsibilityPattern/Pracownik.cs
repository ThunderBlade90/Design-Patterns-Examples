using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    abstract class Pracownik
    {
        public string Imie { get; set; }

        //wskaźnik na następnego pracownika
        protected Pracownik kolejny;

        /// <summary>
        /// Metoda ustawiająca adres do nastepengo pracownika
        /// </summary>
        /// <param name="pracownik">Adres do obiektu pracownika</param>
        public void UstawKolejnego(Pracownik pracownik)
        {
            kolejny = pracownik;
        }

        /// <summary>
        /// Metoda symulująca obsługę zadania
        /// </summary>
        /// <param name="zadanie">Rodzaj zadania</param>
        public abstract void WykonajZadanie(Zadania zadanie);
    }
}
