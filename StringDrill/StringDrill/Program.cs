using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Abdul";
            string string2 = "Rashid";
            string string3 = "Aria";
            Console.WriteLine("My Full Name is: "+string1+string2+string3);

            string FullName = string1 + " " + string2 + " " + string3;
            FullName = FullName.ToUpper();
            Console.WriteLine(FullName);

            StringBuilder paragraph = new StringBuilder("This is the first line of the paragraph. ");
            paragraph.Append("This is the first is the second line of the paragraph. ");
            paragraph.Append("This is the third line of the paragraph. ");
            paragraph.Append("This is the final line of the paragraph. ");
            Console.WriteLine(paragraph);

            Console.Read();

        } 
    }
}
