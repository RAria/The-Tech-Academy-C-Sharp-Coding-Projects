﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateString = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourlyRateString);
            Console.WriteLine("Hours Worked per week?");
            string weekHoursString = Console.ReadLine();
            int weekHours = int.Parse(weekHoursString);
            int annualSalary1 = weekHours * 52 * hourlyRate;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateString2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hourlyRateString2);
            Console.WriteLine("Hours Worked per week?");
            string weekHoursString2 = Console.ReadLine();
            int weekHours2 = Convert.ToInt32(weekHoursString2);
            int annualSalary2 = weekHours2 * 52 * hourlyRate2;

            Console.WriteLine("Does Person 1 make more money than Person 2");
            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrFalse);
            Console.Read();


        }
    }
}