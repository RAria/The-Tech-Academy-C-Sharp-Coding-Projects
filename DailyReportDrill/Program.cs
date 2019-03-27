using System;


namespace DailyReportDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string CurrentCourse = Console.ReadLine();
            //Console.WriteLine(CurrentCourse);

            Console.WriteLine("What page number?");
            string PageNumberString = Console.ReadLine();
            int PageNumberInt = Convert.ToInt16(PageNumberString);
            //Console.WriteLine(PageNumberInt);
         
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHoursString = Console.ReadLine();
            int studyHoursInt = Convert.ToInt16(studyHoursString);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();


        }
    }
}
