using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class AnimalBuilder
    {
        public Animal Animal;

        public abstract void BuildAnimalHeader();
        public abstract void BuildAnimalBody();
        public abstract void BuildAnimalLeg();
        public abstract void BuildAnimalArm();
        public abstract void BuildAnimalTail();
    }
}
