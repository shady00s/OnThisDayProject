using System;

namespace OnThisDayProject
{
    class Program
    {

       


        // the input handeler takes the return value from InputTester method and if the value is false then the application will restart 

        public static void InputHandeler() {
            Console.Write("Enter day  (from 1 to 366): "  );
            string DayTime = Console.ReadLine();
            Console.Write($"Enter Year  (Not exceeds {DateTime.Now.Year}): ");
            string Year = Console.ReadLine();


            CalenderCalculator CC = new CalenderCalculator();
            CC.Year = Year;
            CC.DayIndex = short.Parse(DayTime);
            CC.MonthCalculator();

            
        }
      
        static void Main(string[] args)
        {
             InputHandeler();

        }
    }
}
