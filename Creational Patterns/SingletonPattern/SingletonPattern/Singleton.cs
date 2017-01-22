using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        //tutaj przechowujemy utworzony ewentualnie obiekt
        private static Singleton _object;

        //kontruktor musi byc prywatny lub protected
        //aby uniemożliwić utworzenie obiektu
        //za pomocą operatora new
        private Singleton() { }

        //publiczna metoda statyczna za pomocą której
        //otzymamy referencję do obiektu
        public static Singleton createObject()
        {
            //sprawdzamy czy już utworzyliśmy instancję klasy
            if (_object == null)
            {
                //jeśli nie to ją tworzymy
                _object = new Singleton();
            }
            //zwracamy instancję obiektu zapisanego
            //w stacznym polu naszej klasy
            return _object;
        }
    }
}
