using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExc
{
    public class Person
    {//Create a class with two properties and a method which concatenate two strings.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: "+FirstName+" "+LastName);
        }
    }
}
