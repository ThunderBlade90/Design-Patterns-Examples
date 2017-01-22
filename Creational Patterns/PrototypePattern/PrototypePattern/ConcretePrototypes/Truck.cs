using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Truck : IVehicle
    {
        public string Label { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDescription()
        {
            return "Truck";
        }
    }
}
