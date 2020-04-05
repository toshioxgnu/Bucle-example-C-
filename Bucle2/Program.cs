using System;

namespace Bucle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Mercedez", "Chevrolet", "Camaro"};

            for (int i = 0 ; i < cars.Length; ++i)
            {
                Console.WriteLine(cars[i]);
            }
            
        }
    }
}