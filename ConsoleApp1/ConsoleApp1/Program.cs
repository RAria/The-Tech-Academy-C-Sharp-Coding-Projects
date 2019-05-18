using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days you want to rent a car");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CarRental(days));
            Console.Read();
        }

        public static decimal CarRental(int days)
        {
            int baseRate = 40;
            decimal totalRent = days * baseRate;

           return  days > 7 ? (totalRent * 50) / 100 : days <= 7 && days >= 3 ? totalRent -= 20 : totalRent;
           
            //if (days > 7)
            //{
            //    totalRent = (totalRent * 50) / 100;
            //    return totalRent;
            //}
            //else if (days <= 7 && days >= 3)
            //{
            //    totalRent -= 20;
            //    return totalRent;
            //}
            //else return totalRent;

        }
    }


}
