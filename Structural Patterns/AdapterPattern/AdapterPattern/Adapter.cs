using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adapter : ITarget
    {
        public void methodA()
        {
            Adaptee adaptee = new Adaptee();
            adaptee.methodB();
        }
    }
}
