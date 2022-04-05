using System;

namespace Lab10_5A
{
    class Program
    {
        static double[] arr;

        static double b;

        static int sizeOfArray;
        static void Main()
        {
            Console.WriteLine("write B-number ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter size of array ");
            sizeOfArray = Convert.ToInt32(Console.ReadLine());

            arr = new double[sizeOfArray];

            NumsGetter();           
        }
        static void NumsGetter()
        {          
            for (int i = 0; i < sizeOfArray; i++)
            {
                Random random = new Random();

                arr[i] = random.Next(-1000, 1000);
            }

            ArrayPrinter();
        }
       // static double Randomizer(double mulVar) { return (Convert.ToDouble(DateTime.Now) % Convert.ToDouble(TimeZone.CurrentTimeZone) * 100; }
        static void ArrayPrinter() {
            Console.WriteLine("Your array: ");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine(arr[i] + ",");
            }
            SatisfactionChecker();
        }
        static void SatisfactionChecker()
        {
            Console.WriteLine("Are you satisfied ? \n Enter Y or N");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.Y)
            {
                Console.Write("Approving... \n");

                ToBComperer();
            }
            else if (consoleKey == ConsoleKey.N)
            {
              //  Console.Clear();
                Console.WriteLine("Moving to first step...");

                NumsGetter();
            }
            else {
                Console.WriteLine("Enter valid answer please");

                SatisfactionChecker();
            }
        }
        static  void ToBComperer()
        {
            int count = 0;
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (Math.Abs(arr[i]) <= b)
                    count++;
            }

            Console.WriteLine(count + " elements of array are less than B-number");

            SatisfactionChecker();
        }
    }
}
