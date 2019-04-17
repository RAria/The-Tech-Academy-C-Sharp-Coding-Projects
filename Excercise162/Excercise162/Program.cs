using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise162
{
    class Program
    {
        static void Main(string[] args)
        {

            //const keyword is used for variables whose value will not be changed while the program is running.
            const string name = "Abdul";
            //var keyword is used for variables whose data type is not defined at declaration of the variable. the compiler will know its type by the value it is going to hold.
            var score = 100;
            //instance of the class with only one parameter passed to it. Second variable is set to zero by default.
            ConstructorChain constructor = new ConstructorChain("Abdul");

        }
    }
}
