using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEx4
{
    //Class has a method which takes and return integer value, it has two parameters. The second parameter is optional as it has a default value.
    public class Method
    {
        public int method(int var1, int var2= 0)
        {
            return var1 + var2;

        }
    }
}
