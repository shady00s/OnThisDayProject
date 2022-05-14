using System;

namespace OnThisDayProject
{
    class Program
    {

       


        // the input handeler takes the return value from InputTester method and if the value is false then the application will restart 

        public static void InputHandeler() {

            string DayTime = Console.ReadLine();
            string Year = Console.ReadLine();


            if (Utils.InputTester(DayTime, Year))
            {
                short dayTime = Convert.ToInt16(DayTime);
                short year = Convert.ToInt16(Year);

                CalenderCalculator Cc = new CalenderCalculator();
                Cc.Year = year;
                Cc.DayIndex = dayTime;
               
               

            }
            else
            {

                InputHandeler();
            }
        }
      
        static void Main(string[] args)
        {
             InputHandeler();

        }
    }
}
