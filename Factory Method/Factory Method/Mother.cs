using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Mother
    {
        public const int _GPremiun = 1;

        public const int _GRegular = 2;

        public static Gasolina MotherCreate(int Tipo)
        {

            switch (Tipo)
            {

                case _GPremiun:
                    return new GasolinaPremiun();

                case _GRegular:
                    return new GasolinaRegular();

                default: return null;
            }

        }
    }
}
