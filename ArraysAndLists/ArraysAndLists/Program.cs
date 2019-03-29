using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        
        //Display for userr to get input
        Console.WriteLine("Hi there, I have a list an array of \"Strings\" an arry of \"Intigers\" and a list of \"Strings\"");
        Console.WriteLine("\nWhich one would you like to see? Enter first letter in capital to see each: \n S for String Array, I for Intiger Array and L for List");
        string input = Console.ReadLine();
        
        //String Array
        string[] stringArry = {"A","B","C"};
        int stringArrayL = stringArry.Length; 
        
        //Intiger Arrary
        int[] intArray = {1,2,3};
        int intArrayL = intArray.Length;

        //String List
        List<string> stringList = new List<String>();
        stringList.Add("John");
        stringList.Add("James");
        stringList.Add("Bob");
        
        int stringListL = stringList.Count;

        //Conditional Statements

        //if statement for input for String Array
        if (input=="S")
        {
            Console.WriteLine("\nOKay! I have "+stringArrayL+" indexes, starting from zero, enter the number you would like to see");
            int num = int.Parse(Console.ReadLine());

            if (num==0)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringArry[0]);
            }
            else if (num == 1)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringArry[1]);
            }
            else if (num == 2)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringArry[2]);
            }
            else
            {
                Console.WriteLine("Ohhh! that index does not exist!");
            }

        }

        //Else if statement for input for Intiger Array
        else if (input == "I")
        {
            Console.WriteLine("\tOKay! I have " + intArrayL + " indexes, starting from zero, enter the number you would like to see");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + intArray[0]);
            }
            else if (num == 1)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + intArray[1]);
            }
            else if (num == 2)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + intArray[2]);
            }
            else
            {
                Console.WriteLine("Ohhh! that index does not exist!");
            }

        }

        //Else if statement for input for String
        else if (input == "L")
        {
            Console.WriteLine("\n\tOKay! I have " + stringListL + " indexes, starting from zero, enter the number you would like to see");
            int num = int.Parse(Console.ReadLine());

            if (num==0)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringList[0]);
            }
            else if (num==1)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringList[1]);
            }
            else if (num==2)
            {
                Console.WriteLine("Here is the value at index " + num + " is " + stringList[2]);
            }
            else
            {
                Console.WriteLine("Ohhh! that index does not exist!");
            }

        }
        else
        {
            Console.WriteLine("Wrong input");
        }
        Console.Read();

        }
    }

