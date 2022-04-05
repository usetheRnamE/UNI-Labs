using System;

namespace Lab10_5A
{
    class Program
    {
        static float[] resistences;

        static int sizeOfArray;
        static void Main()
        {
            Console.WriteLine("Enter size of array ");
            sizeOfArray = Convert.ToInt32(Console.ReadLine());

            resistences = new float[sizeOfArray];

            NumsGetter();
        }
        static void NumsGetter()
        {
            for (int i = 0; i < sizeOfArray; i++)
            {
                Random random = new Random();

                resistences[i] = (float)random.NextDouble() * random.Next(1, 10);
            }

            ArrayPrinter();
        }
  
        static void ArrayPrinter()
        {
            Console.WriteLine("Your array: ");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write(resistences[i] + ", ");
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
                Console.WriteLine("resistance of parallel: " + ROfParallel() + "\n resistance of consistent: " + ROfConsistent());

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
        static double ROfParallel()
        {
            double result = 0;
            for (int i = 0; i < resistences.Length; i++)
            {
                result += Math.Pow(resistences[i], -1);
            }
            return result;
        }
        static double ROfConsistent()
        {
            double result = 0;
            for (int i = 0; i < resistences.Length; i++)
            {
                result += resistences[i];
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
