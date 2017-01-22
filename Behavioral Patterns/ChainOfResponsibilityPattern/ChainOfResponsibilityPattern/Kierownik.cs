﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Kierownik : Pracownik
    {
        public Kierownik(string imie)
        {
            this.Imie = imie;
        }

        public override void WykonajZadanie(Zadania zadanie)
        {
            //sprawdzenie, czy ten obiekt powinien obsłużyć żądanie
            if (zadanie == Zadania.Finanse)
            {
                Console.WriteLine("{0} o imieniu {1} obsługuje zadanie: {2}",
                    this.GetType().Name, Imie, zadanie);
            }
            else if (zadanie == Zadania.Inne)
            {
                Console.WriteLine("{0} o imieniu {1} obsługuje zadanie: {2}",
                    this.GetType().Name, Imie, zadanie);
            }
            else if (kolejny != null)
            {
                kolejny.WykonajZadanie(zadanie);
            }

        }
    }
}
