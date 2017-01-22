using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// The MakeDrink abstract class
    /// </summary>
    public abstract class MakeDrink
    {
        public virtual void BoildWater()
        {
            Console.WriteLine("The water is boiling...");
        }

        public abstract void AddIngredien();

        public virtual void SpilCup()
        {
            Console.WriteLine("I spil the cup");
        }

        public abstract void AddCondiment();

        public void Run()
        {
            BoildWater();
            AddIngredien();
            SpilCup();
            AddCondiment();
        }
    }
}
