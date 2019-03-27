using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number to multiply by 50...");
            string number1String = Console.ReadLine();
            int number1Int = Convert.ToInt32(number1String);
            int finalNumber = number1Int * 50;
            Console.WriteLine("The total is "+finalNumber);
            Console.Read();

            Console.WriteLine("please enter a number to add to 25...");
            string number2string = Console.ReadLine();
            int number2Int = Convert.ToInt32(number2string);
            int addition = number2Int + 25;
            Console.Write("the total is "+addition);
            Console.Read();

            Console.WriteLine("Please enter a number to divide by 12.5");
            string number3String = Console.ReadLine();
            double number3Double = Convert.ToDouble(number3String);
            double divide = number3Double / 12.5;
            Console.Write("The result is "+divide);
            Console.Read();

            Console.WriteLine("Please enter a number...");
            String number4String = Console.ReadLine();
            int number4Int = Convert.ToInt32(number4String);
            bool comparison = number4Int > 50;
            Console.Write(comparison);
            Console.Read();

            Console.WriteLine("Please enter a number to divide it by 7 and get the remainder...");
            string number5String = Console.ReadLine();
            int number5Int = Convert.ToInt32(number5String);
            int remainder = number5Int % 7;
            Console.Write("The remainder is..."+remainder);
            Console.Read();

        }
    }
}
