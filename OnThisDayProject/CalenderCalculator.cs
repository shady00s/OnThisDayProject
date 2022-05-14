using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThisDayProject
{
    // this class takes the day number and year from UserInputModel class and convert the data to date format (day of week / day / month / year)
    class CalenderCalculator
    {
        // getting from the user  ( day number(from 1 to 366 ) and year )
        public short DayIndex { get; set; }
        public short Year { get; set; }

        //checks if the year is leap year or not by take the modulus of the year is =0 
        // Leap year equation : 100 % year  400 % year
            
        public bool isLeapYear() {
            if (Year % 100 == 0 && Year % 100 == 0)
                return true;

            else
                return false;
        }



    }
}
