using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program asks the user for two integers input and takes the input and pass it to method's parameters as arguments and returns the result.
            Console.WriteLine("Please enter two whole numbers for math operation");
            Console.WriteLine(" Enter first number");
            //display for input
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            //call methods of the class Math
            Math math = new Math();
            int sum = math.Sum(num1, num2);
            int multiply = math.Multiply(num1, num2);
            int substract = math.Substract(num1, num2);

            //display the returned value by methods
            Console.WriteLine("\n\tHere is the result for addition: "+sum);
            Console.WriteLine("\n\tHere is the result for multiplication: " + multiply);
            Console.WriteLine("\n\tHere is the result for substraction: " + substract);
            Console.ReadLine();
        }
    }
}
