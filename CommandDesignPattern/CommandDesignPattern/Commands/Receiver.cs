using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class Receiver
    {
        public void Action1()
        {
            Console.WriteLine( "Receiver is performing Action 1" );
        }

        public void Action2()
        {
            Console.WriteLine( "Receiver is performing Action 2" );
        }
    }
}
