using System;


namespace OnThisDayProject
{
    class Model
    {

        public bool StringChecker(string[] value) {

            string days = value[0];
            string year = value[1];

            if (LetterAndSymbolChecker(days) && LetterAndSymbolChecker(year) && InputTester(days,year) ) {

                short day = short.Parse(days);
                    // takes value of user input and send it to be calculated
                CalenderCalculator Cc = new CalenderCalculator() { DayIndex = days, Year = year };
                return true;
            }
            else
            {

                return false;
            }
        
        }



        private static bool LetterAndSymbolChecker(string StringSample)
        {
            bool result = false;
            char[] StringSampleValue = StringSample.ToCharArray();

            foreach (char item in StringSampleValue)
            {
                if (!char.IsLetter(item) && !char.IsSymbol(item))
                {

                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;



        }

        // to check if the input values are matching the requirements
        // -  Dont contain any letter or string (string tester method)
        // -  Dont contain any exceed number ( day index not exceeds 366 , year not index the current year

        private static bool InputTester(string DayIndex, string Year)
        {

            CalenderCalculator calenderCal = new CalenderCalculator();


            // to check if the input doesn't contain any letter or string by calling StringTester method

            if (LetterAndSymbolChecker(DayIndex) == true && LetterAndSymbolChecker(Year) == true)
            {
                short dayIndex = Convert.ToInt16(DayIndex);
                short year = Convert.ToInt16(Year);


                // checking if the day index is less than 366 (for heap year exception)  and the year is not more than the current year
                if (dayIndex > 1 && dayIndex <= 366 && year <= DateTime.Now.Year)
                {

                    calenderCal.DayIndex = dayIndex;
                    calenderCal.Year = Year;

                    return true;

                }
                // display error when  day index  is out of range  (0 > day time > 366 )
                else if (dayIndex > 366 || dayIndex <= 0)
                {


                    Console.WriteLine("Wrong Entry , please Enter a valied input from 1 to 366. ");
                }

                // display error when year exceads the current year
                else if (year > DateTime.Now.Year)
                {

                    Console.WriteLine("Don't rush , this year will come with its events :)");
                }

            }


            else { Console.WriteLine("Wrong input "); }
            return false;

        }

        

    }
}
