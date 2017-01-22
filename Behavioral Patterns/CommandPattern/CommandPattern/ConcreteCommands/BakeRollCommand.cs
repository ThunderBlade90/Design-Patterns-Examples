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
    public class BakeRollCommand : ICommand
    {
        private Roll _roll;
        public BakeRollCommand(Roll roll)
        {
            this._roll = roll;
        }

        public void Execute()
        {
            _roll.Bake();
        }
    }
}
