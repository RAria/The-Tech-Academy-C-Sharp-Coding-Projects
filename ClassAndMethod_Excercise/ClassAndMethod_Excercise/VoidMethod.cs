using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_Excercise
{//A class with method that has two parameters. The method within the class will receive two intigers and do a math power operation and display the second integer.
 //The assignment did not ask to return the result of the operation, I will leave it that way.
    public class VoidMethod
    {
        public void method(int var1, int var2)
        {
            int power = var1 * var1;
            Console.WriteLine(var2);
        }
    }
}
