using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class KittenBuilder : AnimalBuilder
    {
        public KittenBuilder()
        {
            Animal = new Kitten();
        }

        public override void BuildAnimalHeader()
        {
            Animal.Head = "Kitten's Head has been built";
        }

        public override void BuildAnimalBody()
        {
            Animal.Body = "Kitten's Body has been built";
        }

        public override void BuildAnimalLeg()
        {
            Animal.Leg = "Kitten's Leg has been built";
        }

        public override void BuildAnimalArm()
        {
            Animal.Arm = "Kitten's Arm has been built";
        }

        public override void BuildAnimalTail()
        {
            Animal.Tail = "Kitten's Tail has been built";
        }
    }
}
