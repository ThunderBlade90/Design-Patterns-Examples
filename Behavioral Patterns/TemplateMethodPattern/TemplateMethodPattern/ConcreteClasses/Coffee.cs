using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// A 'ConcreteClass' - Coffee
    /// </summary>
    public class Coffee : MakeDrink
    {
        public override void AddIngredien()
        {
            Console.WriteLine("I'm adding some cofee beans");
        }

        public override void AddCondiment()
        {
            Console.WriteLine("I'm adding sugar and milk");
        }
    }
}
