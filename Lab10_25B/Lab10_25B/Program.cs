using System;

namespace Lab10_25B
{
    class Program
    {
        static float[,] matrix;

        static float[] vector;

        static int xSizeOfArray, ySizeOfArray, lengthOfArray;
        static void Main()
        {
            Console.WriteLine("Enter size of x column");
            xSizeOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of y column");
            ySizeOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of size of vector");
            lengthOfArray = Convert.ToInt32(Console.ReadLine());

            if (xSizeOfArray != lengthOfArray)
            {
                Console.WriteLine("EROR: M have to be equal to size of vector");
                Restart();
            }

            matrix = new float[xSizeOfArray, ySizeOfArray];
            vector = new float[lengthOfArray];

            NumsGetter();
        }
        static void NumsGetter()
        {
            for (int x = 0; x < xSizeOfArray; x++)
            {
                for (int y = 0; y < ySizeOfArray; y++)
                {
                    Random random = new Random();

                    matrix[x, y] = (float)random.NextDouble() * random.Next(1, 10);
                }
            }
            for (int x = 0; x < lengthOfArray; x++)
            {
                Random random = new Random();

                vector[x] = (float)random.NextDouble() * random.Next(1, 10);
            }
            ArrayPrinter();
        }

        static void ArrayPrinter()
        {
            Console.WriteLine("Ur matrix looks like: ");
            for (int y = 0; y < ySizeOfArray; y++) 
            {
                for (int x = 0; x < xSizeOfArray; x++)
                {
                    Console.Write(matrix[x, y] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Ur array looks like: ");
            for (int x = 0; x < lengthOfArray; x++)
            {
                Console.WriteLine(vector[x] + ", ");
            }

            SatisfactionChecker();
        }

      static void MatrixByVectorMul()
        {
           Console.WriteLine("Matrix * vector is equal to: ");

          double result = 0;
           for (int x = 0; x < xSizeOfArray; x++)
                {
                for (int y = 0; y < ySizeOfArray; y++)
                    {
                    result = matrix[x, y] * vector[x] ;
                    Console.Write(result + ", ");
                }
                Console.WriteLine();
            }
        }

        static void SatisfactionChecker()
        {
            Console.WriteLine("\n Are you satisfied ? \n Enter Y or N");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.Y)
            {
                Console.Write("Approving... \n");
                MatrixByVectorMul();

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
