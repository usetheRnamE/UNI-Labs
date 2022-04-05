using System;

namespace Lab9_5A
{
    class Program
    {
        static double leftBound, rightBound, numOfDevision, precision;
        static int methodChoosen;
        static void Main()
        {
               Console.WriteLine("Enter numOfDevision");
               numOfDevision = Convert.ToDouble(Console.ReadLine());

          Bounds:
                Console.WriteLine("Enter left bound:");
                leftBound = Convert.ToDouble(Console.ReadLine());
         
                Console.WriteLine("Enter right bound:");
                rightBound = Convert.ToDouble(Console.ReadLine());
             
            if (rightBound > leftBound)
                precision = (rightBound - leftBound) / numOfDevision;
            else
            {
                Console.WriteLine("Right bound have to be bigger than left");
                goto Bounds;
            }

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
      static  double MultiRectangelMethod(double plusToXVar)
        {
            double result = 0;
            for (double i = leftBound; i < rightBound; i += precision)
            {
                result += Func(i + plusToXVar) * precision;
            }
            return result;
        }
       static double LRectagleMethod()
        {
            double result = MultiRectangelMethod(0);
            
                return result;
        }

      static  double CRectagleMethod()
        {
            double result = MultiRectangelMethod((precision / 2));

                return result;
        }
       static double RRectagleMethod()
        {
            double result = MultiRectangelMethod(precision);

                return result;
        }
      static  double TrapMethod()
        {
            double result = 0;
            for (double i = leftBound; i < rightBound; i += precision)
            {
                result += (Func(i) + Func(i + precision)) * precision / 2;
            }
            return result;
        }
       static double SimpsonMethod()
        {
            double result = 0;
            for (double i = leftBound; i < rightBound; i += precision)
            {
                result += (Func(i) + 4 * Func(i + precision / 2) + Func(i + precision)) * precision / 6;
            }
            return result;
        }
        #endregion

      static  void ResultWriter(double result)
        {
            Console.WriteLine("Result: " + result);
        }

       static double Func(double xVal)
        {
            return Math.Pow((xVal + 1), 2) * Math.Exp(xVal);
        }
    }
}
