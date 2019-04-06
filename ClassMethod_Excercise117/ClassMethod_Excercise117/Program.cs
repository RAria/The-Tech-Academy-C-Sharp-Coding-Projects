using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_Excercise117
{
    class Program
    {
        static void Main(string[] args)
        {   //Class instantiation
            Methods method = new Methods();
            
            //First method takes input from user and pass an output to variable result.
            decimal result;
            Console.WriteLine("Please enter a number to divide by 2");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Methods.voidMethod(num1, out result);
            Console.WriteLine("Here is the result of frist method "+result);

            //Second method is overloaded. takes two integers and outputs the multiplication to variable multiply.
            int multiply;
            int var1 = 2;
            int var2 = 5;
            Methods.voidMethod(var1, var2, out multiply);
            Console.WriteLine("\nAnd the result for overloaded method: "+multiply);
            Console.ReadLine();
            
        }
        //Static class.
        public static void staticClass()
        {

        }
    }
}
