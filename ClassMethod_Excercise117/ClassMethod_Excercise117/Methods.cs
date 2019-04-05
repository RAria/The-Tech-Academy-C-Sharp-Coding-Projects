using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_Excercise117
{
    public class Methods
    {//void methods that take and output decimal value. Method is overloaded.
        public static void voidMethod(decimal var1, out decimal output)
        {
            output = var1/2;
  
        }
        public static void voidMethod(int var1, int var2, out int multiply)
        {
            multiply = var1 * var2;
        }

    }
}
