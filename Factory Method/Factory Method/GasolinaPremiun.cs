using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
   public class GasolinaPremiun : Gasolina
    {

        public override int ConsumoxMinuto()
        {
            return 15;
        }
    }
}
