using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Scooter : IVehicle
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDescription()
        {
            return "Scooter";
        }
    }
}
