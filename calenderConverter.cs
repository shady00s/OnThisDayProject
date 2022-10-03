      
           public class CalenderObject{
            public double? month {get;set;}
            public int? day {get;set;}
           }
    class CalenderConverter{
      
      private class MonthVals {
           public String? monthName{get;set;}
            public int monthVal {get;set;}

            
        }

        public CalenderObject numberConverter(int dayValue){
            List<MonthVals> months = new List<MonthVals>();
             months.Add(new MonthVals{monthName = "jan",monthVal = 31});
             months.Add(new MonthVals{monthName = "feb",monthVal =28 });
             months.Add(new MonthVals{monthName = "mar",monthVal = 31});
             months.Add(new MonthVals{monthName = "apr",monthVal = 30});
             months.Add(new MonthVals{monthName = "may",monthVal = 31});
             months.Add(new MonthVals{monthName = "jun",monthVal = 30});
             months.Add(new MonthVals{monthName = "jul",monthVal = 31});
             months.Add(new MonthVals{monthName = "aug",monthVal = 31});
             months.Add(new MonthVals{monthName = "sep",monthVal = 30});
             months.Add(new MonthVals{monthName = "oct",monthVal = 31});
             months.Add(new MonthVals{monthName = "nov",monthVal = 30});
             months.Add(new MonthVals{monthName = "dec",monthVal = 31});
           

                // divide the dayValue by 30.417   to. get the month 

                // add all the previous months values 

                // subtract the dayValue and the previous months value  and the target month to get the day of the month

                double month = dayValue ==31? 1 : Math.Floor(dayValue / 30.417) +1;

                int totalMonthsValue = 0;
                int monthDaysValue = 0;

                for(int x = 0 ; x < month; x++){
                    monthDaysValue = months[x].monthVal;
                        totalMonthsValue += months[x].monthVal;
                }

                int dayOfTheMonthValue  = (monthDaysValue - (totalMonthsValue-dayValue));


            return new  CalenderObject{day =dayOfTheMonthValue, month = month};
        }
    }


