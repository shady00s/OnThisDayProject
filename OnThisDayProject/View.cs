using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThisDayProject
{
    class View
    {
        public string[] DateUserInputUi() {
            Console.Write("Enter day  (from 1 to 366): ");
            string DayTime = Console.ReadLine();
            Console.Write($"Enter Year  (Not exceeds {DateTime.Now.Year}): ");
            string Year = Console.ReadLine();
            string[] result = new string[2] { DayTime, Year };
            return result;
        }

        public void OnUserInputError() {
            Console.WriteLine();
        }
        public void DataOutPut() {

            Console.Write($"Enter Year  (Not exceeds {DateTime.Now.Year}): ");
        }
    }
}
