using System;
using System.Collections.Generic;

namespace Lab5_5C
{
    class Program
    {       
        static List<int> numSequence = new List<int>();

        const int lowerBounds = 0;
        static void Main()
        {
            #region NumEntering 
            int i = 0;
            int userInput;
            do
            {
                Console.WriteLine("Enter " + i + " # of seqquence");
                userInput = Convert.ToInt32(Console.ReadLine());

                numSequence.Add(userInput);       

                i++;
            } while (lowerBounds != userInput);
              Console.WriteLine("All #'s was entered");
            #endregion

            #region NumSorting
            numSequence.Sort();

            Console.WriteLine("The lowest #'r whith id 'n' is " + Convert.ToString(numSequence[0])
                + ", #'r whith id 'n + 1' is " + Convert.ToString(numSequence[1]));
            #endregion
        }
    }
}
