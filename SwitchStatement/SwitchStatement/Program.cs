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

           Console.WriteLine("If you divide 100 by 2 and add 5 and multiply by 4 and substract 6 and divide the final number to 2 what is the result? ");
            int result = int.Parse(Console.ReadLine());
           bool resultBolean = result == 107;

            do
            {
                switch (result)
                {
                    case 107:
                        Console.WriteLine("You got it!");
                        resultBolean = true;
                        break;


                    default:
                        Console.WriteLine("Not quite right!");
                        Console.WriteLine("Lets try it again");
                        result = int.Parse(Console.ReadLine());
                        break;

                }

            }
            while (!resultBolean);
            Console.Read();


        }
    }
}
