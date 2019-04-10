using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_140
{
    public class EmployeeInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public EmployeeInfo(string firstName, string lastName, int Id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Id = Id;
        }

    }
}
