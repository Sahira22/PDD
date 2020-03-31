using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class AvailavleServerState : ServerState
    {
        public override void Answer()
        {
            Console.WriteLine("Trabajo Equlibrado");
        }
    }
}
