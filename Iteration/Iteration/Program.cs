using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {



            //1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.
            //Array of string which saves input from user
            string[] stringArray = new string[5];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("\nPlease enter any name at index " + i);
                string name = Console.ReadLine();
                stringArray[i] = name;

            }
            for (int k = 0; k < stringArray.Length; k++)
            {
                Console.WriteLine("\nHere is what you have entered at index " + k + " " + stringArray[k]);
            }

            //infinite loop
            //2.create an infinite loop.
            //3.fix the infinite loop so it will execute.
            bool infinite = 3 > 6;

            while (!infinite)
            {
                Console.WriteLine("\ninfinite");

            }

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine("\nLine# " + j);

            }

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int a = 5; a <= 10; a++)
            {
                Console.WriteLine("\nLine# " + a);

            }

            //6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8. Add code to that above loop that stops it from executing once a match has been found.

            List<string> myList = new List<string> { "james", "bob", "camaron", "tom" };
            Console.WriteLine("\nenter a name to search. please dont use capital characters");
            String enteredName = Console.ReadLine();
            int b = 0;
            bool trueOrFalse = myList[b] == enteredName;


            for (b = 0; b < myList.Count; b++)
            {

                //if the condition is met, break the loop.
                if (myList[b] == enteredName)
                {
                    Console.WriteLine("\nThere you go, we were able to find " + enteredName + " in our database.\n it is located in index# " + b);

                    break;
                }

            }
            //if the bool vaule is false after iteration.
            if (b == myList.Count)
            {
                if (!trueOrFalse)
                {
                    Console.WriteLine("\nThe name " + enteredName + " does not exist in our database");
                }
            }

            //9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //Console.WriteLine("Please enter a fruit name to search, for accuracey in search all leters should be lower case.");
            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            Console.WriteLine("\nenter name of the fruit to search. for accuracey in search please type all letters in lower case");
            string findFruit = Console.ReadLine();
            List<string> fruit = new List<string> { "banana", "apple", "orange", "pineapple", "banana", "apple" };
            List<string> basket = new List<string>();

            //iterates through the list and prints the index number of the list, if any match found. Adds the found item to an empty list.
            for (int c = 0; c < fruit.Count; c++)
            {
                if (fruit[c] == findFruit)
                {
                    basket.Add(fruit[c]);
                    Console.WriteLine("\nA match has been found for your search. The fruit is located at shelf# " + c);

                }

            }

            //if no match found during the iteration.
            if (basket.Count == 0)
            {
                Console.WriteLine("\nsorry we could not find a match for your fruit...looks like it is not at stock.");
            }

            //11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, 
            //and displays a message showing the string and whether or not it has already appeared in the list.
            //Create two empty lists to store duplicate and non duplicate
            List<string> listOfStrings = new List<string> { "math", "chemistery", "biology", "physics", "math", "science", "literature", "biology", "math" };
            List<string> noDuplicate = new List<string>();
            List<string> duplicate = new List<string>();
            foreach (string subject in listOfStrings)
            {
                //if it has not been already on the list then add it. else add add it to duplicate list.
                if (!noDuplicate.Contains(subject))
                {
                    noDuplicate.Add(subject);
                }
                else
                {
                    duplicate.Add(subject);

                }
            }

            //print nonDuplicate list
            foreach (string subject in noDuplicate)
            {
                Console.WriteLine("\n"+subject);

            }

            //print duplicates
            foreach (string subject in duplicate)
            {
                Console.WriteLine("\n" + subject + "  duplicate");

            }

            Console.Read();
        }
    }
}
