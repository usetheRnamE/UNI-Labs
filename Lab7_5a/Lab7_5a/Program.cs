using System;

namespace Lab7_5a
{
    class Program
    {
        static double a, h;
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                a = Math.Abs(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Enter h");
                h = Math.Abs(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("P equal to : " + Triangle(a, h));
            }
        }
        static double Triangle(double a, double h)
        {
            double bSide = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));

            double P = 2 * bSide + a;

            return P;
        }
    }
}
