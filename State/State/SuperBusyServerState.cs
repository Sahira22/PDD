using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SuperBusyServerState : ServerState
    {
        public override void Answer()
        {
            Console.WriteLine("SuperSobrecargado");
        }
    }
}
