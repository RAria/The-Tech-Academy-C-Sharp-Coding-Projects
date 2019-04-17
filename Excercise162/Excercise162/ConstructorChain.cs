using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise162
{
    public class ConstructorChain
    {
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
