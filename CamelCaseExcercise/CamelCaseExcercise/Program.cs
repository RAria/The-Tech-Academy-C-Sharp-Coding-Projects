using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CamelCaseExcercise
{
   public static class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Please enter a text to convert to Camel Case ");
            string input = Console.ReadLine();

            string output = Convert(input);

            Console.WriteLine(output);
            Console.ReadLine();


        }
        public static string Convert(string str)
        {
            if (str == null) return string.Empty;
            
            TextInfo txtInfo = new CultureInfo("en-us", false).TextInfo;
            str = txtInfo.ToTitleCase(str.ToLower()).Replace(" ", string.Empty); return str;
        }

     
        
    }
}
