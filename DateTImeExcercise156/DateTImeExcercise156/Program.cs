using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTImeExcercise156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: "+DateTime.Now);
            Console.WriteLine("\nPlease enter a number to set the time");
            double hour = Convert.ToDouble(Console.ReadLine());
            //set the hour of the current time to the input entered by the user.
            string dateTime = System.DateTime.Now.AddHours(hour).ToString("hh:mm:ss");

            
            Console.WriteLine(dateTime);
           
            Console.Read();
        }
    }
}
