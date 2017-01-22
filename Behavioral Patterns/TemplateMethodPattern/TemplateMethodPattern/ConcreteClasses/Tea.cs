using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// A 'ConcreteClass' - Tea
    /// </summary>
    public class Tea : MakeDrink
    {
        public override void AddIngredien()
        {
            Console.WriteLine("I'm adding some tea leaf");
        }

        public override void AddCondiment()
        {
            Console.WriteLine("I'm adding sugar and limone");
        }
    }
}
