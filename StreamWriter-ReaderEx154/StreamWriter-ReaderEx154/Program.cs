using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter_ReaderEx154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number =Console.ReadLine();
            //creates or overwrites file name log if already exist and log any value passed to variable number.
            File.WriteAllText(@"C:\Users\Student\Desktop\log.txt", number);
            
            //reads text from log file and prints it to console.
            Console.WriteLine(File.ReadAllText(@"C:\Users\Student\Desktop\log.txt"));
            Console.ReadLine();
        }
    }
}
