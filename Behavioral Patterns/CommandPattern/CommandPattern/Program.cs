using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery();
            Roll roll = new Roll();
            BakeRollCommand brc = new BakeRollCommand(roll);
            bakery.SetCommand(brc);
            bakery.StartBaking();

            Bread bread = new Bread(KindOfBread.Black);
            BakeBreadCommand bbc = new BakeBreadCommand(bread);
            bakery.SetCommand(bbc);
            bakery.StartBaking();

            Console.ReadLine();
        }
    }
}
