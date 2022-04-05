using System;

namespace Lab10_25A
{
    class Program
    {
        static float[,] matrix;

        static int mSizeOfArray, nSizeOfArray;

        static int k;
        static void Main()
        {
            Console.WriteLine("Enter size of M column");
            mSizeOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of N column");
            nSizeOfArray = Convert.ToInt32(Console.ReadLine());

            kAssigner:
            Console.WriteLine("Enter k ( 1 < k < M )");
            k = Convert.ToInt32(Console.ReadLine());

            if (k < 1 || k > mSizeOfArray)
                goto kAssigner;

            matrix = new float[mSizeOfArray, nSizeOfArray];

            NumsGetter();
        }
        static void NumsGetter()
        {
            for (int i = 0; i < nSizeOfArray; i++)
            {
                Random random = new Random();

                matrix[i, k] = (float)random.NextDouble() * random.Next(1, 10);
            }
         /*   for (int i = 0; i < matrix.Length; i++)
            {
                Random random = new Random();

                matrix[0, i] = (float)random.NextDouble() * random.Next(1, 10);
            }/*/

            ArrayPrinter();
        }

        static void ArrayPrinter()
        {
            Console.WriteLine("Your k column: ");
            for (int i = 0; i < nSizeOfArray; i++)
            {
                Console.Write(matrix[i, k] + ", ");
            }
            SatisfactionChecker();
        }
        static void SatisfactionChecker()
        {
            Console.WriteLine("\n Are you satisfied ? \n Enter Y or N");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.Y)
            {
                Console.Write("Approving... \n");
                Console.WriteLine("Sum of K column: " + SumOfKElements() + "\n Multiplication of K column: " + MulOfKelements());

                Restart();
            }
            else if (consoleKey == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine("Moving to first step...");

                NumsGetter();
            }
            else
            {
                Console.WriteLine("Enter valid answer please");

                SatisfactionChecker();
            }
        }
        static double SumOfKElements()
        {
            double result = 0;
            for (int i = 0; i < nSizeOfArray; i++)
            {
                result += matrix[i, k];
            }
            return result;
        }
        static double MulOfKelements()
        {
            double result = 1;
            for (int i = 0; i < nSizeOfArray; i++)
            {
                result *= matrix[i, k];
            }
            return result;
        }
        static void Restart()
        {
            Console.WriteLine("Press R to restart");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.R)
            {
                Console.Clear();
                Main();
            }
        }
    }
}
