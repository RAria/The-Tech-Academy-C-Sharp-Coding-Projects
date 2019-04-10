using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_140
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation of the EmployeeInfo class and adding values to the instantiated list.
            List<EmployeeInfo> employees = new List<EmployeeInfo>();
            employees.Add(new EmployeeInfo("Joe", "Rogan", 1));
            employees.Add(new EmployeeInfo("Bob", "Hunt", 2));
            employees.Add(new EmployeeInfo("Tom", "Cruise", 3));
            employees.Add(new EmployeeInfo("Joe", "Freeman", 4));
            employees.Add(new EmployeeInfo("Camel", "Case", 5));
            employees.Add(new EmployeeInfo("Shah", "Khan", 6));
            employees.Add(new EmployeeInfo("Moon", "Light", 7));
            employees.Add(new EmployeeInfo("Adam", "Smith", 8));
            employees.Add(new EmployeeInfo("Michael", "Jackson", 9));
            employees.Add(new EmployeeInfo("Abdul", "Aria", 10));

            //create new list as an object of the EmployeeInfo class. search employee list and add any value to the new list matching the set condition.
            List<EmployeeInfo> tempList = new List<EmployeeInfo>();

            //iterates through employee list and add any value matching the condition set in If statement.
            foreach (EmployeeInfo search in employees)
            {
                if (search.firstName == "Joe")
                {
                    tempList.Add(search);
                }

            }

            //display the added values to tempList.
            foreach (var search in tempList)
            {
                Console.WriteLine("Employee Info (tempList): {0}, {1}, {2}", search.firstName, search.lastName, search.Id);
            }



            //the above iteration with lambda expression. instantiate a new list of type EmployeeInfo class, find and add any value to the new list that - 
            //matches the set condition.
            List<EmployeeInfo> newList = employees.Where(x => x.firstName == "Joe").ToList();

            //display the added values to newList.
            foreach (var search in newList)
            {
                Console.WriteLine("\nEmployee Info (newList): {0}, {1}, {2}", search.firstName, search.lastName, search.Id);
            }

            //creates new list of EmployeeInfo type, goes through employees list, find and add to new list any value where Id is greater than 5.
            List<EmployeeInfo> greaterThan5 = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\n\t"+greaterThan5.Count);
            Console.Read();
        }


      
    }

   
}
