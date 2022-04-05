using System;

namespace Lab8_5C
{
    class Program
    {
        static double dx, leftBoud, rightBoud, presicion;
        static int maxLoopCount, methodWhichChoosen;
        static void Main()
        {
            #region Inisialization
            Console.WriteLine("Enter left boud: ");
            leftBoud = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter right boud: ");
            rightBoud = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter presicion: ");
            presicion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter maxLoopCount: ");
            maxLoopCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter wich method would you prefer: 0 - Newton method, 1 - binnary method");
            methodWhichChoosen = Convert.ToInt32(Console.ReadLine());
            #endregion

            switch (methodWhichChoosen)
            {

                case 0:
                    if (Func(rightBoud) * SecondFuncDerivative(rightBoud) > 0)
                        Console.WriteLine("x +- " + presicion + " equal to: " + NewtonMethod(rightBoud));
                    else if (Func(leftBoud) * SecondFuncDerivative(leftBoud) > 0)
                        Console.WriteLine("x +- " + presicion + " equal to: " + NewtonMethod(leftBoud));
                    else
                        Console.WriteLine("For this equation method of Newton cannot be applied");
                    break;

                case 1:
                    Console.WriteLine("x +- " + presicion + "equal to: " + BinnaryMethod());
                    break;
            }
        }

        #region Func`s
        static double Func(double funcArgument)
        {
            double result = Math.Pow(funcArgument, 3) - 10 * Math.Pow(funcArgument, 2) + 44 * funcArgument + 29;

            return result;
        }
        static double FirstFuncDerivative(double funcArgument)
        {
            double presicionKoef = presicion / 1000;

            double result = Math.Pow(presicionKoef, -1) * (Func(funcArgument + presicionKoef) - Func(presicionKoef));

            return result;
        }
        static double SecondFuncDerivative(double funcArgument)
        {
            double presicionKoef = presicion / 1000;

            double result = Math.Pow(presicionKoef, -2) * (Func(funcArgument + presicionKoef) - 2 * Func(funcArgument) + Func(funcArgument - presicionKoef));

            return result;
        }
        #endregion

        #region NewtonMethod
        static double NewtonMethod(double boud)
        {
            for (int i = 0; i < maxLoopCount; i++)
            {
                dx = Func(boud) / FirstFuncDerivative(boud);

                boud -= dx;

                if (Math.Abs(dx) <= presicion)
                    return boud;
            }
            return 0;
        }
        #endregion

        #region BinnaryMethod
        static double BinnaryMethod()
        {
            double lBound = leftBoud, rBound = rightBoud;
            double middlePoint = Math.Pow(2, -1) * (lBound + rBound);
            double result;
            while (Math.Abs(rBound - lBound) < presicion)
            {
                if (Func(middlePoint) == 0)
                    return middlePoint;

                    if (Func(lBound) * Func(middlePoint) < 0)
                        rBound = middlePoint;
                    else
                        lBound = middlePoint;
            }

            result = Math.Pow(2, -1) * (lBound + rBound);

            return result;
        }
        #endregion
    }
}

