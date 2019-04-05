using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExc
{//inherite the person class so this class and its instantiated objects will have access to that class's fields.
    class Employee : Person
    {
        public int Id { get; set; }
    }
}
