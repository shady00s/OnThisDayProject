    class InputValidator{
            public bool dayIsValid(int day){
                if((day == 0 || day >= 365 ) || (day.GetType() == typeof(String))   || day == -1){
                    return false;
                }
                else{
                    return true;
                }
            }
    }