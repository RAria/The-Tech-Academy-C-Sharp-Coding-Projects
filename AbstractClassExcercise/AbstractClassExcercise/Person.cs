using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExcercise
{
    public abstract class Person
    {//abstract class with abstract method.
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName(string firstName, string lastName);
        
    }
}
