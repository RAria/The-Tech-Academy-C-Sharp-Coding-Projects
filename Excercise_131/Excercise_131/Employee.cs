using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_131
{//class and its property list with generic type.
    public class Employee<T>
    {
        public List<T> things { get; set; }
    }
}
