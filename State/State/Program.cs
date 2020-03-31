using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {

            ServerCon nServer = new ServerCon();
            



            nServer.State = new AvailavleServerState();
            nServer.DependiendoVolSolicitudes();
            nServer.DependiendoVolSolicitudes();


            nServer.State = new BusyServerState();
            nServer.DependiendoVolSolicitudes();
            nServer.DependiendoVolSolicitudes();

            nServer.State = new SuperBusyServerState();
            nServer.DependiendoVolSolicitudes();
            nServer.DependiendoVolSolicitudes();


        }
    }
}
