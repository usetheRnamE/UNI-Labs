using System;

namespace Lab6_5A
{
    class Program
    {
      static int a1 = 1, q = 2;

        static long kNum, sumOfProg;
        static void Main()
        {
            Console.WriteLine("Sum of progression finder");
            Console.WriteLine("Enter k");
            int k = Convert.ToInt32(Console.ReadLine());

            kNum = a1;
            Console.WriteLine("All nums of prog: ");

            for (int i = 0; i < k; i++)
            {
                sumOfProg += kNum;
             
                kNum = kNum * q;
                Console.WriteLine(kNum);
            }

      
            Console.WriteLine("The result is: " + sumOfProg);
        }
    }
}
