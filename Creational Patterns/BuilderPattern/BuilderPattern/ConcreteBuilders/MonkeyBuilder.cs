using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MonkeyBuilder : AnimalBuilder
    {
        public MonkeyBuilder()
        {
            Animal = new Monkey();
        }

        public override void BuildAnimalHeader()
        {
            Animal.Head = "Moneky's Head has been built";
        }

        public override void BuildAnimalBody()
        {
            Animal.Body = "Moneky's Body has been built";
        }

        public override void BuildAnimalLeg()
        {
            Animal.Leg = "Moneky's Leg has been built";
        }

        public override void BuildAnimalArm()
        {
            Animal.Arm = "Moneky's Arm has been built";
        }

        public override void BuildAnimalTail()
        {
            Animal.Tail = "Moneky's Tail has been built";
        }
    }
}
