using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class - dot
    /// </summary>
    class CharacterDot : Character
    {
        // Constructor
        public CharacterDot()
        {
            this.symbol = '.';
            this.height = 20;
            this.width = 20;
            this.ascent = 70;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }
}
