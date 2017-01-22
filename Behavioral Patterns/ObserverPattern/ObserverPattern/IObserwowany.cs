using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IObserwowany
    {
        int jakasWlasciwosc { get; set; }

        void dodajObserwatora(IObserwator o);
        void usunObserwator(IObserwator o);
        void powiadomObserwatorow();
    }
}
