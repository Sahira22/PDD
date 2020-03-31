using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class CxCompany
    {


        private static CxCompany instancia = null;
        public string mensaje = "";
        protected CxCompany()
        {

            mensaje = "Somos CxCompany siempre a tu lado";

        }


        public static CxCompany Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new CxCompany();
                return instancia;
            }
        }


    }
}
