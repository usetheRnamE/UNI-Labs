using System;

namespace Lab7_C1_3
{
    class Program
    {
       static  int mass = 6, startSpeed = 800;
       static  float gammaK = .18f, gravAcc = 9.81f;

       static float aAngle;

        static float Time;
       static double gammaMassK = mass / gammaK;
   
        static void Main()
        {

            Console.WriteLine("Enter alfa angle");
            aAngle = (float)Convert.ToDouble(Console.ReadLine());

            do
            {
                Time += 0.01f;

                Console.WriteLine("Y Speed:" + YFindFunc() / Time + "            ||           " + "X Speed:" + XFindFunc() / Time);
            }
            while (YFindFunc() >= 0);

        }

        static double XFindFunc()
        {
            double xFunc = gammaMassK * startSpeed * MathF.Cos(aAngle) * (1 - MathF.Exp(-gammaK * Time / mass));

            return xFunc;
        } 
        static double YFindFunc()
        {
            double yFunc = gammaMassK * (startSpeed * MathF.Sin(aAngle) + gammaMassK * gravAcc) * (1 - MathF.Exp(-gammaK * Time / mass)) - gammaMassK * gravAcc * Time;

            return yFunc;
        }
    }
}
