using System;

namespace Lab4_1C
{
    class Program
    {
        static double length; 

        static double speedOfTaxi, speedOfWalk;

        static double paymentForKms, paymentYouCanAfford;

        static double Time;
        static void Main()
        {
            #region initialisation
            Console.WriteLine("Count best route");
            Console.WriteLine("Enter length");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter speed of taxi");
            speedOfTaxi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter speed of walk");
            speedOfWalk = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter payment for taxi (grn/km)");
            paymentForKms = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time");
            Time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter payment you can afford");
            paymentYouCanAfford = Convert.ToDouble(Console.ReadLine());
            #endregion

           #region Comfort solution
            double paymentForTaxi = paymentForKms * length;
             double timeSpendedInTaxi = length / speedOfTaxi;

            if (timeSpendedInTaxi <= Time && paymentForTaxi <= paymentYouCanAfford)
            {
                Console.WriteLine("The taxi is possible solution \n" + "Payment for taxi will be equal to: " + paymentForTaxi.ToString());
            }
            else
                Console.WriteLine("The taxi is not possible solution");
             #endregion

             #region Cheap solution
             double timeSpendedInWalk = length / speedOfWalk;
       
             if (timeSpendedInWalk <= Time)
            {
                Console.WriteLine("The walk is possible solution \n" + "Payment will be equal to: 0");
            }     
             else
                 Console.WriteLine("The walk is not possible solution");
             #endregion

            #region Mixed solution   
            if (paymentForTaxi > paymentYouCanAfford)
            { 

                double moneyToSave = paymentForTaxi - paymentYouCanAfford;

                double affordableLength = moneyToSave / paymentForKms; // return Kms

                double walkableLength = length - affordableLength;

                double walkableTime = walkableLength / speedOfWalk;
                double partTimeInTaxi = affordableLength / speedOfTaxi;

                if ((walkableTime + partTimeInTaxi) <= Time)
                    Console.WriteLine("Mixed solution is founded: \n" + "Money which you will save: "
                        + moneyToSave.ToString() + "\n Length which you will spend in taxi: " + affordableLength.ToString()
                        + "\n Length which you will walk: " + walkableLength.ToString() + "\n Time in walk: " + walkableTime.ToString()
                        + "Time in taxi: " + partTimeInTaxi.ToString());
                else
                    Console.WriteLine("There is not any mixed solution for you");
            }

            #endregion
        }
    }
}
