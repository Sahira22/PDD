using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class BusyServerState : ServerState
    {
        public override void Answer()
        {
            Task.Delay(500);
            Console.WriteLine("Saturado");

        }
    }
}
