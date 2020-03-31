using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
     public class ServerCon
    {

        private ServerState state;

        public ServerState State
        {

            get
            {
                return state;
            }


            set
            {

                state = value;
            }
        
        
        }
        public void DependiendoVolSolicitudes()
        {


            state.Answer();

        }


    }
}
