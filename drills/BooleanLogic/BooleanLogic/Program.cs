using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);
            bool ageBool = age > 15;

            Console.WriteLine("Have you ever had a DUI?");
            string DUIString = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIString);
            

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketString = Console.ReadLine();
            int ticket = Convert.ToInt16(ticketString);
            bool ticketBool = ticket < 3;

            bool qualified = ageBool == true && DUI==false && ticketBool == true;
            Console.WriteLine("Qualified? ... " +qualified);

            Console.Read();

        }
    }
}
