using System;

namespace Lab7_5b
{
    class Program
    {

        static double xLeftBorder = 3, xRightborder = 5, xMiddlePoint, presicion = 0.00001;

        static void Main()
        {
            
            while (xRightborder - xLeftBorder > presicion)
            {
                if (Func(xLeftBorder) * Func(BinarySearch()) == 0)
                    break;

               else if (Func(xLeftBorder) * Func(BinarySearch()) < 0)
                    xRightborder = xMiddlePoint;

                else
                    xLeftBorder = xMiddlePoint;

                Console.WriteLine(xMiddlePoint);
            }

            Result();
        }

        static double BinarySearch()
        {
            xMiddlePoint = 0.5d * (xLeftBorder + xRightborder);

            return xMiddlePoint;
        }


        static double Func(double funcNum)
        {
            double funcResult;

            funcResult = Math.Exp(funcNum) - 6 * funcNum - 30;

            return funcResult;
        }

        static void Result() { Console.WriteLine("func = "+ Func(xLeftBorder) +", if x = " + xMiddlePoint); }
    }
}
