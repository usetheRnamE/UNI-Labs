using System;

namespace Lab6_3C
{
    class Program
    {
        static double a, b, c;

        static int sumOfSqr = 0;
        static void Main()
        {
            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c");
            c = Convert.ToDouble(Console.ReadLine());

            int aLoopCount = 0, bLoopCount = 0;
            while (a >= c)
            {
                a -= c;

                aLoopCount++; //кількість квадратиків, що поміщаються на стороні а
            }
            while (b >= c)
            {
                b -= c;

                bLoopCount++; //кількість квадратиків, що поміщаються на стороні b
            }

            while (bLoopCount > 0)
            {
                sumOfSqr += aLoopCount;

                bLoopCount--;     
            }

            Console.WriteLine("sum of squers is equal to: " + sumOfSqr);
        }
    }
}
