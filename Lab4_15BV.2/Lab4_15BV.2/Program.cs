using System;

namespace Lab4_15BV._2
{
    class Program
    {
        static int currentDay;

        static string[] days = new string[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"};
        static void Main()
        {
            DaysApp();
        }
        static void DaysApp()
        {
            Console.WriteLine("Enter day num");

            currentDay = Convert.ToInt32(Console.ReadLine());
             double loopOfWeeks = currentDay / 7;

             double resultDay = currentDay - days.Length * loopOfWeeks;
             Console.WriteLine(days[Convert.ToInt32(--resultDay)]);       
        }
    }
}
