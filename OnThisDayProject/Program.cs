using System;

namespace OnThisDayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            View  view= new View();
            Model model = new Model();


            view.DateUserInputUi();

            if (model.StringChecker(view.DateUserInputUi()))
            {
                Console.WriteLine("sucsess");
            }
            else {
                view.OnUserInputError();
                view.DateUserInputUi();
            }
           



        }
    }
}
