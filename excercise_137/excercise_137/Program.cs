using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_137
{
    class Program
    {//instantiation of struct and assigning value to the object.
        static void Main(string[] args)
        {
            Number object1 = new Number();
            object1.Amount = 5;

            //print the value.
            Console.WriteLine(object1.Amount);
            Console.ReadLine();
        }
        
    }
}
