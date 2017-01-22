using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class Bread
    {
        private KindOfBread _kindOfBread;
        public KindOfBread KindOfBread
        {
            get
            {
                return _kindOfBread;
            }
            set
            {
                _kindOfBread = value;
            }
        }

        public Bread(KindOfBread kindOfBread)
        {
            this._kindOfBread = kindOfBread;
        }

        public void Bake()
        {
            Console.WriteLine("I'm Baking {0} bread", this._kindOfBread);
        }
    }
}
