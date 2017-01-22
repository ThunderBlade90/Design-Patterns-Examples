using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Pacjent> pacjenci = new List<Pacjent>();
            //pacjenci.Add(new ChoryNaGlowe("Jan Kowalski"));
            //pacjenci.Add(new ChoryNaGlowe("Stefan Kowalewski"));
            //pacjenci.Add(new ChoryNaNoge("Janusz Malinowski"));
            //pacjenci.Add(new ChoryNaZoladek("Adam Mickiewicz"));

            //// Leczenie
            //IVisitor leczenie = new Leczenie2();
            //foreach (Pacjent p in pacjenci)
            //{
            //    p.Accept(leczenie);
            //}

            //Console.WriteLine("-----");

            //IVisitor wypis = new Wypis();
            //foreach (Pacjent p in pacjenci)
            //{
            //    p.Accept(wypis);
            //}

            // Setup structure
            StrukturaPacjentow sp = new StrukturaPacjentow();
            sp.Dolacz(new ChoryNaGlowe("Jan Kowalski"));
            sp.Dolacz(new ChoryNaGlowe("Stefan Kowalewski"));
            sp.Dolacz(new ChoryNaNoge("Janusz Malinowski"));
            sp.Dolacz(new ChoryNaZoladek("Adam Mickiewicz"));

            // Create visitor objects
            Leczenie leczenie = new Leczenie();
            Wypis wypis = new Wypis();

            // Structure accepting visitors
            sp.Accept(leczenie);
            Console.WriteLine("-----");
            sp.Accept(wypis);

            Console.ReadKey();
        }
    }
}
