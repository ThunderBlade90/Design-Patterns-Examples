using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zainicjowanie obiektów
            Pracownik kierownikAndrzej = new Kierownik("Andrzej");
            Pracownik mechanikAudi = new MechanikAudi("Tomek");
            Pracownik mechanikBMW = new MechanikBMW("Władek");

            //Ustawienie elementów listy jednokierunkowej
            kierownikAndrzej.UstawKolejnego(mechanikAudi);
            mechanikAudi.UstawKolejnego(mechanikBMW);

            //Przykładowy zbiór zadań
            List<Zadania> zadaniaNaDzis = new List<Zadania> {
                Zadania.BMW,
                Zadania.Finanse,
                Zadania.Audi,
                Zadania.Inne
            };

            //Poszukiwanie odpowiedzialnego za dane zadanie
            foreach (var zadanie in zadaniaNaDzis)
            {
                kierownikAndrzej.WykonajZadanie(zadanie);
            }

            Console.ReadLine();
        }
    }
}
