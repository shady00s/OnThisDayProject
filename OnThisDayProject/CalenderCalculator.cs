using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThisDayProject
{
    // days class

    class DaysVal
    {
        public String Name { get; set; }
        public int val { get; set; }
    }


    class GregorianCalendar
    {
        public int Name { get; set; }
        public int val { get;set; }
    }
    // days list

    class MonthsValue
    {

        public String MonthName { get; set; }
        public int MonthVal { get; set; }

    }
    // this class takes the day number and year from UserInputModel class and convert the data to date format (day of week / day / month / year)
    class CalenderCalculator
    {
        // getting from the user  ( day number(from 1 to 366 ) and year )
        public short DayIndex { get; set; }
        public string Year { get; set; }

        //checks if the year is leap year or not by take the modulus of the year is =0 
        // Leap year equation : 100 % year  400 % year
        
        public bool isLeapYear() {
            short YearInNumber = Convert.ToInt16(Year);
            if (YearInNumber % 100 == 0 && YearInNumber % 400 == 0)
                return true;

            else
                return false;
        }

       public int DayOfTheWeekCalculator(int monthNumber ,int dateNumber)
        {

            List<MonthsValue> MonthValForWeek = new List<MonthsValue> {
                //
                new MonthsValue{MonthName = "jan", MonthVal = 0},
                new MonthsValue{MonthName = "feb", MonthVal = 3},
                new MonthsValue{MonthName = "mar", MonthVal =3},
                new MonthsValue{MonthName = "apr", MonthVal = 6},
                new MonthsValue{MonthName = "may", MonthVal = 1},
                new MonthsValue{MonthName = "june",MonthVal = 4},
                new MonthsValue{MonthName = "july",MonthVal = 6},
                new MonthsValue{MonthName = "aug", MonthVal =2},
                new MonthsValue{MonthName = "sept",MonthVal =5},
                new MonthsValue{MonthName = "oct", MonthVal = 0},
                new MonthsValue{MonthName = "nov", MonthVal = 3},
                new MonthsValue{MonthName = "dec", MonthVal = 5},

            };
            string[] nameOfMonth = MonthValForWeek.Select(d => d.MonthName).ToArray();
            int[] MonthVal = MonthValForWeek.Select(d => d.MonthVal).ToArray();


            List<GregorianCalendar> CG = new List<GregorianCalendar> {


                /*
                 1700s = 4
                1800s = 2
                1900s = 0
                2000s = 6
                2100s = 4
                2200s = 2
                2300s = 0
                 
                 */
                new GregorianCalendar{ Name = 17,val = 4},
                new GregorianCalendar{ Name = 18,val = 2},
                new GregorianCalendar{ Name = 19,val = 0},
                new GregorianCalendar{ Name = 20,val = 6},
                
            };
            int[] centeryCode = CG.Select(d => d.val ).ToArray();
            int[] centeryCodeName = CG.Select(d => d.Name).ToArray();


            //The formula is:

            //(Year Code + Month Code + Century Code + Date Number - Leap Year Code) mod 7


            //to get last two digits
            // short year = Convert.ToInt16((Year % 100) / 4);
            char[] year = Year.ToCharArray();
            short firstTwoNumbersFromYear= Convert.ToInt16( String.Join("",year[0],year[1]));

            short lastTwoNumbersFromYear= Convert.ToInt16( String.Join("",year[2],year[3]));

            Console.WriteLine(lastTwoNumbersFromYear);
            
            int yearCode = lastTwoNumbersFromYear +  (lastTwoNumbersFromYear / 4 ) ;
            int centeryVal = 0;

            for (int i = 0; i < centeryCodeName.Length; i++)
            {
                if (centeryCodeName[i] == firstTwoNumbersFromYear) {
                    centeryVal += centeryCode[i];
                   
                }
            }
            

            int monthCode = MonthVal[monthNumber];

           

            int result = (yearCode + monthCode + dateNumber + centeryVal - ( isLeapYear() == false ? 0 : 1)) % 7;

            return result;
        }

        public void MonthCalculator() {

            List<DaysVal> dayVals = new List<DaysVal>{
            new DaysVal{Name ="Sunday",val =0 },
            new DaysVal{Name ="Monday",val =1 },
            new DaysVal{Name ="Tuesday",val =2 },
            new DaysVal{Name ="Wednesday",val =3 },
            new DaysVal{Name ="Thursday",val =4 },
            new DaysVal{Name ="Friday",val =5 },
            new DaysVal{Name ="Saturday",val =6 },

        };

            string[] nameOfDay = dayVals.Select(d => d.Name).ToArray();

            List<MonthsValue> monthsVals = new List<MonthsValue> {

                new MonthsValue{MonthName = "jan", MonthVal = 31},
                new MonthsValue{MonthName = "feb", MonthVal = (isLeapYear() == false ? 28 : 29)},
                new MonthsValue{MonthName = "mar", MonthVal = 31},
                new MonthsValue{MonthName = "apr", MonthVal = 30},
                new MonthsValue{MonthName = "may", MonthVal = 31},
                new MonthsValue{MonthName = "june",MonthVal = 30},
                new MonthsValue{MonthName = "july",MonthVal = 31},
                new MonthsValue{MonthName = "aug", MonthVal = 31},
                new MonthsValue{MonthName = "sept",MonthVal = 30},
                new MonthsValue{MonthName = "oct", MonthVal = 31},
                new MonthsValue{MonthName = "nov", MonthVal = 30},
                new MonthsValue{MonthName = "dec", MonthVal = 31},
            };

            // make loop and subtract days value from monthsVal enum and add one into number of months variable

           

            string[] nameOfMonth = monthsVals.Select(d => d.MonthName).ToArray();
            int[] val = monthsVals.Select(d => d.MonthVal).ToArray();

           

            int monthNumber = DayIndex / 31;
            int dayCal = 0;
            int valueOFTheDay = 0;
            if (DayIndex <= 31)
            {
                Console.WriteLine($"The Date is { nameOfDay[DayOfTheWeekCalculator(monthNumber, valueOFTheDay)]}, {DayIndex }/ {nameOfMonth.First()} / {Year}");
            }
            else
            {
                for (int x = 0; x < monthNumber; x++)
                {
                    //to create the number of the days 
                    dayCal += val[x];
                    valueOFTheDay = DayIndex - dayCal;
                }
             
                Console.WriteLine($"The Date is { nameOfDay[DayOfTheWeekCalculator(monthNumber, valueOFTheDay)]},  {valueOFTheDay}/ {nameOfMonth[monthNumber]}  / {Year}");
            }
           ApiClass ac = new ApiClass();

            ac.getDataFromApi(12, 2, 2021);



        }

        
    }
}
