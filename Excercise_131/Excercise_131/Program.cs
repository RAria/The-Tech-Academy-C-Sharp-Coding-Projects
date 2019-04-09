using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_131
{
    class Program
    {
        static void Main(string[] args)
        {//object instantiation of the employee class with a string data type.
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() {"A","B","C","D","E" };

            //object instantiation of the employee class with an integer data type.
            Employee<int> integers = new Employee<int>();
            integers.things = new List<int>() {1,2,3,4,5};

            //loops to print the stored values.
            foreach (string search in employee.things)
            {
                Console.WriteLine(search);
                
            }

            foreach (int search in integers.things)
            {
                Console.WriteLine(search);
            }
            Console.ReadLine();


        }
    }
}
