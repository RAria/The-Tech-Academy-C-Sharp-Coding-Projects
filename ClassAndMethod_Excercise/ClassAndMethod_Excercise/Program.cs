using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            VoidMethod voidMethod = new VoidMethod();
            //call the method by passing arguments
            voidMethod.method(4, 5);
            // call the method by specifying names of the parameters.
            voidMethod.method(var1 : 6, var2:8 );
            Console.ReadLine();
        }
        
    }
}
