using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class ConcreteCommand2 : ICommand
    {
        private readonly Receiver _receiver;

        public ConcreteCommand2( Receiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action2();
        }
    }
}
