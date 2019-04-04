using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEx3
{
    //A class with 3 methods which take one argument of different data types and do math operations and return the result as integer.
    public class Method
    {
        //Method takes argument of integer data type.
        public int sum(int var1)
        {
           return  var1 + var1;
        }

        //Method takes argument of decimal datat ype.
        public int sum(decimal var2)
        {
            return Convert.ToInt32(var2 * var2);

        }

        //Method takes argument of string data type.
        public int sum(string var3)
        {
            int var = int.Parse(var3);

            return var - var;

        }
    }
}
