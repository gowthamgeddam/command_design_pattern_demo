using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Commands;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main()
        {
            Receiver receiver = new Receiver();
            ICommand command1 = new ConcreteCommand1( receiver );
            ICommand command2 = new ConcreteCommand2( receiver );

            Invoker invoker = new Invoker();

            invoker.SetCommand( command1 );
            invoker.ExecuteCommand(); // Executes Action 1 through ConcreteCommand1

            invoker.SetCommand( command2 );
            invoker.ExecuteCommand(); // Executes Action 2 through ConcreteCommand2
        }
    }
}
