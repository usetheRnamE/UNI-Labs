using System;
using System.Drawing;
namespace Lab12_5
{
    class Program
    {

        private static float precision = 0.001f;

      //  private Font Font;

        static void Main()
        {
            Console.WriteLine("Choose method of integration \n 1 - Simple Integrations \n 2 - Newton Method");

            int choosenNum = Convert.ToInt32(Console.ReadLine());

            switch (choosenNum)
            {
                case 1:
                    Console.WriteLine("You chose simple integrations method");
                    SimpleIntegrate();
                    break;
                case 2:
                    Console.WriteLine("You chose Newton method ");
                    NewtonItegrate();
                    break;
                default:
                    Console.WriteLine("Index is out of range, choose 1 or 2 pls\n\n\n");
                    Main();
                    break;
            }

        }

        #region Simple Iterations Method

     /*   static void SumOfDerivative()
        {
            double sumOfDerivative = 0;
            for (double i = 0; i < 1; i += precision)
            {
               sumOfDerivative += Derivative(i, 0);
            }

            Console.WriteLine(sumOfDerivative);
        }*/

        static void SimpleIntegrate()
        {
            double[] x = {1, 0};

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Derivative(x, i);

                if (Math.Abs(x[i] - Derivative(x, i)) <= precision)
                    break;
            }

            #region printing stuff
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x["+ i +"] = " + x[i]);
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Func = " + Func(x, i));
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Derivative = " + Derivative(x, i));
            }
            #endregion
        }
        #endregion

        #region Newton Method
   
       /* private static void NewtonIntegrate()
        {
            double[] x = { 1, 0 };
            for (int i = 0; i < itMax; i++)
            {

            }
        }*/    
     

        // Find a root by using Newton's method.
        private static void NewtonItegrate()
        {
            double[] zeroX = { 0.537853, -0.138685 };
           // const float cutOff = .0000001f;
            const int maxIterations = 1000;
            double epsilon;
            int iterations = 0;

                    for (int i = 0; i < 2; i++)
                    {
                        do
                        {
                            // Display this guess zeroX
                            iterations++;                         
                            Console.WriteLine(iterations + ": " + zeroX[i]);

                            // Make sure zeroX isn't on a flat spot
                            while (Math.Abs(Derivative(zeroX, i)) < precision) zeroX[i] += precision;

                            // Calculate the next estimate for zeroX
                            epsilon = -Func(zeroX, i) / Derivative(zeroX, i);
                            zeroX[i] += epsilon;
                        } while ((Func(zeroX, 0) != 0 && Func(zeroX, 1) != 0) && iterations < maxIterations);                   
                    }

            Console.WriteLine("1th func with argument: " + Func(zeroX, 0) + "\n2th func with argument: " + Func(zeroX, 1));

            Console.WriteLine("x = " + zeroX[0] + " || y =  " + zeroX[1] + " in " + iterations / 2 + " iterations");
        }
        #endregion

        #region Function and Stuff
        // The function.
        private static double Func(double[] x, int funcNum)
        {
            switch (funcNum)
            {
                case 0:
                    return Math.Sin(x[0] + .5f) - x[1] - 1;
                case 1:
                    return Math.Cos(x[1] - 2) + x[0];
                default:
                    Console.WriteLine("Eror: index of func is out of the bounds");
                    return 0;
            }
        }

        // The function's derivative.
        private static double Derivative(double[] x, int funcNum)
        {
            switch (funcNum)
            {
                case 0:
                    return  Math.Cos(x[0] + .5f) - 1;
                case 1:
                    return -Math.Sin(x[1] - 2) + 1;
                default:
                    Console.WriteLine("Eror: index of func is out of the bounds");
                    return 0;
            }
        }
        #endregion
    }
}
