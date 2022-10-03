namespace View
{
    class View
    {
        private int intro()
        {

            Console.WriteLine($"\n Please enter The day number (from 1 to 365).");

            Console.Write("day: ");
            String? dayVal = Console.ReadLine();
            int result;

            // check if the input is not letter if 
            if (!int.TryParse(dayVal, out result)) return result = -1;

            else return result;


        }
        private void introErr()
        {
            Console.WriteLine("The number is not valid , please enter the number again.");


        }

        private int eventType()
        {
            Console.WriteLine($"\n Choose the event type");
            Console.WriteLine($"\n 1- Event");
            Console.WriteLine(" 2- Death");
            Console.WriteLine(" 3- Birth");
            Console.Write("\n Number of event: ");
            String? eventNumber = Console.ReadLine();
            int result;

            if (int.TryParse(eventNumber, out result)) return result;


            else return -1;
        }
        private void eventErr()
        {
            Console.WriteLine($"\nInvalid event number , please insert it again");
        }
        private void showResult(int eventType, int numberVal)
        {


            List<Wikipedia> resorces = new List<Wikipedia>();
            Console.WriteLine("Please wait ...");

            GetApiController controllers = new GetApiController();

            //convert the number that the user entered and convert it to day/month object
            CalenderConverter calenderConv = new CalenderConverter();

            CalenderObject convertedObj = calenderConv.numberConverter(numberVal);


            var data = controllers.getApiData(convertedObj, eventType);
            //event
            if (eventType == 1)
            {
                foreach (var item in data.events!)
                {
                    Console.WriteLine($"In {item.year}, {item.description}. ");

                    Console.WriteLine($"\n Wekipedia resources: ");

                    for (var i = 0; i < item.wikipedia!.Count; i++)
                    {
                        Console.WriteLine($"{item.wikipedia[i].title}. ");
                        Console.WriteLine($"{item.wikipedia[i].wikipedia}. ");

                        Console.WriteLine($"\n----------------------------------------------------- ");

                    }


                }

            }

            // deaths
            else if (eventType == 2)
            {
                foreach (var item in data.deaths!)
                {
                    Console.WriteLine($"In {item.year}, {item.description}. ");

                    Console.WriteLine($"\n Wekipedia resources: ");

                    for (var i = 0; i < item.wikipedia!.Count; i++)
                    {
                        Console.WriteLine($"{item.wikipedia[i].title}. ");
                        Console.WriteLine($"{item.wikipedia[i].wikipedia}. ");

                        Console.WriteLine($"\n----------------------------------------------------- ");

                    }


                }

            }

            // births
            else
            {
                foreach (var item in data.births!)
                {
                    Console.WriteLine($"In {item.year}, {item.description}. ");

                    Console.WriteLine($"\n Wekipedia resources: ");

                    for (var i = 0; i < item.wikipedia!.Count; i++)
                    {
                        Console.WriteLine($"{item.wikipedia[i].title}. ");
                        Console.WriteLine($"{item.wikipedia[i].wikipedia}. ");

                        Console.WriteLine($"\n----------------------------------------------------- ");

                    }


                }

            }

            Console.WriteLine("Press any key to exit ... ");
            Console.ReadKey();




        }
        public void applicationFlow()
        {
            InputValidator validator = new InputValidator();
            int introVal = intro();
            bool isValid = validator.dayIsValid(introVal);

            // to repeat the function if the user didn't enter the correct number.
            while (!isValid)
            {
                introErr();

                introVal = intro();
                isValid = validator.dayIsValid(introVal);
            }

            if (isValid)
            {
                int events = eventType();
                // to repeat the function if the user didn't enter the event correct number.

                showResult(events, introVal);



            }




        }
    }




}