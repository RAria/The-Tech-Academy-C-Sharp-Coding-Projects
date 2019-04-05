using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input.
            Console.WriteLine("The calculator is for addition and can take up to two numbers. The second number is optional and set to default value of 0.");
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 or press enter to process the default value");
            string var2 = Console.ReadLine();
            int num2;
            //Since the second input is optional, this control statement is to account for two possible options. If the input is entered or if it is left empty.
            //if the second input was not entered then call the method with default variable which is 0.
            if (string.IsNullOrEmpty(var2))
            {
                num2 = 0;
            }
            //if the input is entered then convert that to integer. The method will then access that value as argument to the second parameter.
            else
            {
                num2 = Convert.ToInt32(var2);
            }
            //instantiate the class and call its method by trying different number combination.
            Method sum = new Method();
            int result1 = sum.method(num1, num2);
            Console.WriteLine(result1);

            int result2 = sum.method(num1);
            Console.WriteLine(result2);

            Console.WriteLine("Combo1 "+sum.method(12));
            Console.WriteLine("Combo2 " +sum.method(12,12));
            Console.ReadLine();
        }

    }
}
