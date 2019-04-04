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
            Console.WriteLine("The calculator is for addition and can take up to two numbers. The second number is set to default value of 0.");
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 or enter 0 for defaul value");
            int num2 = Convert.ToInt32(Console.ReadLine());

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
