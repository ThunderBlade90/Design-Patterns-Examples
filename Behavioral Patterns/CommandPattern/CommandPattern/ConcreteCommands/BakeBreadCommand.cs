using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class BakeBreadCommand : ICommand
    {
        private Bread _bread;
        public BakeBreadCommand(Bread bread)
        {
            this._bread = bread;
        }

        public void Execute()
        {
            _bread.Bake();
        }
    }
}
