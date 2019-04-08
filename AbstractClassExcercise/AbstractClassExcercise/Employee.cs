using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExcercise
{
    public class Employee : Person, IQuittable
    {//Employee class inherit Person class' properties which includes the method. The method is set in parent class as requirement to be implemented by any inheritance.

        //method is exactly the same as parent class.
        public override void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Entered name is: "+firstName+" "+lastName);

        }
        
        //Quit method implemented from IQuittable interface which is inheritted by this class.
        public void Quit()
        {
            Console.WriteLine("I quit!");

        }
    }
}
