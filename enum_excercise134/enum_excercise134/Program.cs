using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_excercise134
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //this try block will compare an input with the enum variable.
                //here we ask the user for input and assign that to a variable of string type.
                Console.WriteLine("Please enter the current day of the week: ");
                string input = Console.ReadLine();

                //here we convert and assign user's input to the variable of Enum type. With the "true" we make sure it is case insensitive.
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input, true);

                //prints the value assigned to enum variable.
                Console.WriteLine("You have entered: " + currentDay);
            }

            //if the try block does not excecute due some input error.
            catch (Exception)
            {

                Console.WriteLine("Please enter an Actual Day of the Week");
            }

            Console.ReadLine();
        }
        //declaring an enum data type with its possible options.
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
