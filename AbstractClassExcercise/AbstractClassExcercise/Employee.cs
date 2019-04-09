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
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Entered name is: "+firstName+" "+lastName);

        }
        
        //Quit method implemented from IQuittable interface which is inheritted by this class.
        public void Quit()
        {
            Console.WriteLine("I quit!");

        }

        //comparing two objects of a class with "==" operator overload.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id.Equals(employee2.Id);
            
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1.Id==employee2.Id);
        }
    }
}
