using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Gasolina object1 = Mother.MotherCreate(Mother._GPremiun);
            Console.WriteLine(object1.ConsumoxMinuto());
        }
    }
}
