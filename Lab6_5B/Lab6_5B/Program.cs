using System;
using System.Numerics;

namespace Lab6_5B
{
    class Program
    {
        static int sign = 1;

        static decimal sumOfProg = 0, precision, x, sum = 0;
        static void Main()
        {
            Console.WriteLine("Endless sum finder \n Enter precision: ");

             precision = Convert.ToDecimal(Console.ReadLine());

           Console.WriteLine("Enter x: ");
           x = Convert.ToDecimal(Console.ReadLine());

           /* x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(Factorial(x));*/
            Console.WriteLine("Func is equal to: " + Func() + " \n Sum is equal to: " + SumOfFunc());         
            Restart();

        }

        static double Func()
        {
            return Math.Exp((double) -x);
        }
        static decimal SumOfFunc()
        {
            int i = 0;
            decimal applier = 0;
              do
              {
                   //формула правильна
                   applier = sign * (decimal)Math.Pow((double)x, i) / (decimal)Factorial(i);
                   sumOfProg += applier; // знаходимо нескінченну суму 
                   sign *= -1;
                   i++;
                 // sum = Math.Abs(sumOfProg - Func());
                //Console.WriteLine(applier);

              } while (Math.Abs(applier) > precision);
            return sumOfProg;
        }

        // факторіал робочий
       static  BigInteger Factorial(int iVar)
        {
            int loopCount = 1;

            BigInteger result = new BigInteger(1);

            if (iVar == 0)
                return 1;
            else if (iVar == 1)
                return 1;
            while (loopCount <= iVar)
            {
                result *= loopCount;
                loopCount++;
            }
            return result;
        }
        static void Restart()
        {
            Console.WriteLine("Press R to restart");
            ConsoleKey key = Console.ReadKey().Key;

            if(key == ConsoleKey.R)
            {
                Console.Clear();
                Main();
            }
        }

    }
}
