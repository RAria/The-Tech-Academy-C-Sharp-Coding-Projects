using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise162
{
    public class ConstructorChain
    {
        //chaining two constructors. The base constructor has two paremerters and the second constructor which is chained to the base constructor has only one parameter.
        //An instance of the class can be created by passing two or only one parameter.
        public ConstructorChain(string name) : this(name, 0)
        {

            
        }
        public ConstructorChain(string name, int bankBalance)
        {
            this.name = name;
            this.bankBalance = bankBalance;
        }


        public string name;
        public int bankBalance;
        
    }
}
