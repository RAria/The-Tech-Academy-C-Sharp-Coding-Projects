using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Method method = new Method();

            //call methods within the class and pass an argument.
            int sum = method.sum(var1 : 12);
            int power = method.sum(var2 : 12.50m);
            int substract = method.sum(var3 : "4");

            //Display the return value.
            Console.WriteLine(sum);
            Console.WriteLine(power);
            Console.WriteLine(substract);

            Console.ReadLine();
        }
    }
}
