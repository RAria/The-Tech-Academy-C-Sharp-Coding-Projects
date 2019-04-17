using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to compare");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(comparison(input));
           // bool result = comparison(input);
            //Console.WriteLine(result);

            //int Os = input.Where(x => x == 'o').Count();
            //int Xs = input.Where(x => x == 'x').Count();
            //Console.WriteLine(Xs == Os);
            
            Console.ReadLine();
        }

        public static bool comparison(string input)
        {
            return int Os = input.Where(x => x == 'o').Count() == int Xs = input.Where(x => x == 'x').Count() ? true : false;
            //int Os = input.Where(x => x == 'o').Count();
            //int Xs = input.Where(x => x == 'x').Count();
            //return (Os==Xs);

        }
        //public static bool comparison(string input)
        //{
        //    int countO = 0;
        //    int countX = 0;
        //    foreach (char c in input)
        //    {
        //        if (c == 'o')
        //        {
        //            countO += 1;
        //        }
        //        else if (c == 'x')
        //        {
        //            countX += 1;
        //        }
        //    }
        //    return (countO==countX);
        //}
    }
}
 