﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Urzadzenie : IObserwator
    {
        //prywatne pole do przechowywanie pobranej temperatury
        private int pobranaTemperatura;
        //referencja do obserwowanego obiektu
        private Czujnik czujnikTemperatury;

        //wraz z definicja obiektu przypisywany mu jest czujnik
        public Urzadzenie(Czujnik o)
        {
            czujnikTemperatury = o;
        }

        //metoda pobierajaca temperature
        public void aktualizacjaDanych()
        {
            pobranaTemperatura = czujnikTemperatury.pobierzTemperature();
            Console.WriteLine("Obiekt pobral temperature rowna {0}", pobranaTemperatura);
        }
    }
}
