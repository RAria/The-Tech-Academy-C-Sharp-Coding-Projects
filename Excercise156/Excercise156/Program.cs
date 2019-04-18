using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //using this bool variable to initialize a while loop so if the user enters anything but digits, it will loop back.
                bool validInput = false;
                int age = 1;
                //while the bool variable is false the loop will iterate.
                while (!validInput)
                {
                    Console.WriteLine("Please enter your age.");
                    validInput =  int.TryParse(Console.ReadLine(), out age);
                    if (!validInput) Console.WriteLine("Number only, no decimals.");
                }
                //if the input is a number but not a positive number i.e. zero or negative, then the console will throw this exception.
                if (validInput && age <= 0)
                {
                    throw new ArgumentException("Entered age must be above 0");
                }

                //this part of code will be excecute only if the input meets the above set criteria.
                //create an instance of the DateTime class with current date.
                DateTime currentDate = DateTime.Now;
                //create a new instance of the DateTime class which substract the input as years from current date.
                DateTime dateTime = currentDate.AddYears(-age);

                //output in two formats.
                //1. short date.
                Console.WriteLine("According to your age, you were born on: " + dateTime.ToShortDateString());
                //2. only year.
                Console.WriteLine("\nAccording to your age, you were born in: "+dateTime.ToString("yyyy"));
                
            }
            //general exception.
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
            Console.ReadLine();

        }
    }
}
