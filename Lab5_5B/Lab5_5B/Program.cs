using System;

namespace Lab5_5B
{
    class Program
    {
       static double Rad;
        static void Main()
        {
            Console.WriteLine("Rad to grad conventor");


          double result;
            while (Rad <= 10d)
            {
                result = 360 / (2 * Math.PI) * Rad;

                Console.WriteLine(Rad + " Rad is equal to  " + result + "grad");

                Rad += .5;
            }
        }
    }
}
