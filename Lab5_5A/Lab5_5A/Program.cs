using System;

namespace Lab5_5A
{
    class Program
    {
        static double xBeginBorder ,xEndBorder, y, stepOfFunction;

        static void Main()
        {
            #region SetValues
            Console.WriteLine("Enter (x) borders");
            Console.WriteLine("x begins with number : ");
            xBeginBorder = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x ends with number : ");
            xEndBorder = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter step of function : ");
            stepOfFunction = Convert.ToDouble(Console.ReadLine());
            #endregion

            if (stepOfFunction <= 0)
                return;


            int loopValue = 1;
         while(xBeginBorder <= xEndBorder)
            {
                y = xBeginBorder * Math.Sqrt(Math.Pow(xBeginBorder, 2) + 1) + Math.Cos(xBeginBorder * (Math.Pow(Math.E, xBeginBorder) / (xBeginBorder + Math.Tan(xBeginBorder))));

                Console.WriteLine(loopValue + ") \n after " + loopValue + " step (Y) equal to: " + y);

                Console.WriteLine(" after " + loopValue + " step (X) equal to: " + xBeginBorder);
                Console.WriteLine("\n ----------------------------------------- \n");

                xBeginBorder += stepOfFunction;
                loopValue++;
            }
        }
    }
}
