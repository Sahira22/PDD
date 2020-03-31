using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class GasolinaRegular : Gasolina
    {

        public override int ConsumoxMinuto()
        {
            return 30;
        }
    }
}
