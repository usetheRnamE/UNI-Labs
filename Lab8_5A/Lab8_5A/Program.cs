using System;

namespace Lab8_5A
{
    class Program
    {
        static double dx, leftBoud, rightBoud, presicion;
        static int maxLoopCount;
        static void Main()
        {
            #region Inisialization
            Console.WriteLine("Enter left bound: ");
            leftBoud = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter right bound: ");
            rightBoud = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter presicion: ");
            presicion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter maxLoopCount: ");
            maxLoopCount = Convert.ToInt32(Console.ReadLine());
            #endregion

            if (Func(rightBoud) * SecondFuncDerivative(rightBoud) > 0)
                Console.WriteLine("x +- " + presicion + " equal to: " + NewtonMethod(rightBoud));
            else if (Func(leftBoud) * SecondFuncDerivative(leftBoud) > 0)
                Console.WriteLine("x +- " + presicion + " equal to: " + NewtonMethod(leftBoud));
            else
                Console.WriteLine("For this equation method of Newton cannot be applied");    
        }

        #region Func`s
        static double Func(double funcArgument)
        {
            double result = Math.Exp(funcArgument) - 6 * funcArgument - 30;

            return result;
        }
        static double FirstFuncDerivative(double funcArgument)
        {
            double presicionKoef = presicion / 1000;

            double result = Math.Pow(presicionKoef, -1) * (Func(funcArgument + presicionKoef) - Func(funcArgument));

            return result;
        }
        static double SecondFuncDerivative(double funcArgument)
        {
            double presicionKoef = presicion / 1000;

            double result = Math.Pow(presicionKoef, -2) * (Func(funcArgument + presicionKoef) - 2 * Func(funcArgument) + Func(funcArgument - presicionKoef));

            return result;
        }
        #endregion

        static double NewtonMethod(double bound)
        {
            for (int i = 0; i < maxLoopCount; i++)
            {
                dx = Func(bound) / FirstFuncDerivative(bound);

                bound -= dx;

                if (Math.Abs(dx) <= presicion)
                    return bound;

                Console.WriteLine("Func is equal to: " + Func(bound));
            }
            return 0;
        }
    }
}
