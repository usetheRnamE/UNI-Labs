using System;

namespace Lab9_5B
{
    class Program
    {
        static double presicion, leftBound = 0, rightBound = 1, numOfDevision;
        static int methodChoosen;
      
        static void Main()
        {     
            Console.WriteLine("Enter numOfDevision");
          numOfDevision = Math.Abs(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Enter presicion");
            presicion = Math.Abs(Convert.ToDouble(Console.ReadLine()));

      /*  Bounds:
            Console.WriteLine("Enter left bound:");
            leftBound = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter right bound:");
            rightBound = Convert.ToDouble(Console.ReadLine());

            if (rightBound > leftBound)
                dx = (rightBound - leftBound) / numOfDevision;
            else
            {
                Console.WriteLine("Right bound have to be bigger than left");
                goto Bounds;
            }    */        

            MethodOptioner();
        }
        static void MethodOptioner()
        {
        MethodToChoose:
            Console.WriteLine("Choose the method please: \n 0 - left rectagle method \n 1 - center rectagle method \n 2 - left rectagle method" +
    " \n 3 - trap method \n 4 - Simpson method");
            methodChoosen = Convert.ToInt32(Console.ReadLine());

            switch (methodChoosen)
            {
                case 0:
                    ResultWriter(LRectagleMethod());
                    break;
                case 1:
                    ResultWriter(CRectagleMethod());
                    break;
                case 2:
                    ResultWriter(RRectagleMethod());
                    break;
                case 3:
                    ResultWriter(TrapMethod());
                    break;
                case 4:
                    ResultWriter(SimpsonMethod());
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    goto MethodToChoose;
            }
        }

        #region Methods
        static double MultiRectangelMethod(double plusToXVar)
        {
            double result = 0;
          
            for (double i = leftBound; i < rightBound; i += presicion)
            {
                    result += sumOfFunc(i + plusToXVar, false) * presicion;
            }
            return result;
        }
        static double LRectagleMethod()
        {
            double result = MultiRectangelMethod(0);

            return result;
        }

        static double CRectagleMethod()
        {
            double result = MultiRectangelMethod((presicion / 2));

            return result;
        }
        static double RRectagleMethod()
        {
            double result = MultiRectangelMethod(presicion);

            return result;
        }
        static double TrapMethod()
        {
            double result = 0;
            for (double i = leftBound; i < rightBound; i += presicion)
            {
                    result += ((Func(leftBound) + Func(rightBound) + 2 * sumOfFunc(i, true))) * presicion / 2;
            }
            return result;
        }
        static double SimpsonMethod()
        {
            double result = 0;
            for (double i = leftBound; i < rightBound; i += presicion)
            {
                    result += (Func(leftBound) + Func(rightBound) + (4 * sumOfFunc(i + presicion / 2, true)) + (2 * sumOfFunc(i + presicion, true))) * presicion / 3;
            }
            return result;
        }
        #endregion

        static void ResultWriter(double result)
        {
            Console.WriteLine("Result: " + result);


            Restart();
        }
        static void Restart()
        {
            Console.WriteLine("Pres R to restart");
            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.R)
            {
                Console.Clear();
                Main();
            }
            else
                Console.Write("Error");
        }
        static double Func(double xVal)
        {
            return 4 / (1 + Math.Pow(xVal,2));
        }
        static double sumOfFunc(double xSumVar, bool isMinusToDev)
        {
            double result = 0;

            if (isMinusToDev)
                --numOfDevision;

            for (int i = 0; i < numOfDevision; i++)
            {       
                    result = +Func(xSumVar);
            }
            return result;
        }
    }
}
