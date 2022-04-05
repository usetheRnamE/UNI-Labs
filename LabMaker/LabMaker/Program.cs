using System;


namespace LabMaker
{
    class Program
    {
        static void Main()
        {
            double x;
            double sqrNumber;

            double deviceMistake;
            const float P = .95f; 

            int button;

            double h;

            double deltaXOkr = 0, deltaXpr = 0, deltaXwithDot = 0;

            const float kStudent = 2.76f;
            Console.WriteLine(" 1 - delta dot finder\n 2 - delta pr finder\n 3 - delta okr finder\n 4 - sum of delta x finder\n 5 - final result finder");

            button = Convert.ToInt32(Console.ReadLine());

            switch (button) {
                #region delta x with dot
                case 1:
                        Console.WriteLine("delta x with dot finder");
                        Console.WriteLine("Enter delta x");

                        x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("sqr num u wana to pow the 10");

                        sqrNumber = Convert.ToDouble(Console.ReadLine());

                         deltaXwithDot = kStudent * (Math.Sqrt(x * Math.Pow(10, sqrNumber) / 20));


                        Console.WriteLine("your delta num = " + deltaXwithDot);
                    break;
                #endregion

                #region delta pr finder 
                case 2:
                
                    Console.WriteLine("delta pr finder ");
                    Console.WriteLine("Enter device mistake ");

                    deviceMistake = Convert.ToDouble(Console.ReadLine());

                     deltaXpr = (2 *  deviceMistake) / 3;

                        Console.WriteLine("your delta num = " + deltaXpr);
                    break;
                #endregion

                #region delta okr finder
                case 3:
           
                    Console.WriteLine("Enter h ");

                    h = Convert.ToDouble(Console.ReadLine());

                      deltaXOkr = (P * h) / 2;

                    Console.WriteLine("delta okr = " + deltaXOkr);
                    break;
                #endregion

                #region  Sum of delta x finder
                case 4:
                    Console.WriteLine("Sum of delta x finder");

                    Console.WriteLine("Enter delta x whit dot ");
                    double deltaXwithDotInputed = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter delta pr");
                    double deltaXprInputed = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter delta okr");
                    double deltaXOkrInputed = Convert.ToDouble(Console.ReadLine());

                    double sumOfDeltaX = Math.Sqrt(Math.Pow(deltaXwithDotInputed, 2) + Math.Pow(deltaXprInputed, 2) + Math.Pow(deltaXOkrInputed, 2));

                    Console.WriteLine("Sum of delta x = " + sumOfDeltaX);

                    break;
                #endregion

                #region  final mistake finder
                case 5:
                    Console.WriteLine("final delta x finder");

                    Console.WriteLine("Enter R");
                    double R = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter delta M ");
                    double deltaM = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter M");
                    double M = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter delta A");
                    double deltaA = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Enter A ");
                    double A = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Enter delta B");
                    double deltaB = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Enter B ");
                    double B = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Enter delta C");
                    double deltaC = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Enter C ");
                    double C = Convert.ToDouble(Console.ReadLine());

                    double finalResult = R * Math.Sqrt(Math.Pow((deltaM / M), 2) + Math.Pow((deltaA / A), 2) + Math.Pow((deltaB / B), 2) + (Math.Pow((deltaC / C), 2)));

                    Console.WriteLine("Sum of delta x = " + finalResult);

                    break;
                    #endregion
            }
        }
    }
}
