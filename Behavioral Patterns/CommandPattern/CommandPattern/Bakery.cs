using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Bakery
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void StartBaking()
        {
            _command.Execute();
        }
    }
}
