using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cany you guess my Name?");
            Console.WriteLine("Here is a hint A***l, all you got to do is fill the blanks...remember my name spelling is case sensitive");
            string myName = Console.ReadLine();
            bool correct = myName == "Abdul"; 
            while (correct!=true)
               
            {
                if (myName == "Abdul")
                {
                    Console.WriteLine("That is right, My first name is " + myName);
                    correct = true;

                }
                else
                {
                    Console.WriteLine("That is not correct!");
                    Console.WriteLine("Lets start all over again, here is the hint again A***l");
                    myName = Console.ReadLine();
                }
                Console.Read();
            }
        }
            
        
    }
}
