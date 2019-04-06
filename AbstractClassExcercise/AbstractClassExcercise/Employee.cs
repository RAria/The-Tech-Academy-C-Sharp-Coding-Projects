using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExcercise
{
    public class Employee : Person
    {

        public override void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Entered name is: "+firstName+" "+lastName);

        }
    }
}
