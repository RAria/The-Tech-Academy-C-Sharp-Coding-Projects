using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

        //Program to ask the user for a number to divide the list of integers by and display the result and catch any error.
        try
        {
            List<decimal> integers = new List<decimal> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Please enter a number to divide by a list of numbers from 1 to 10");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            decimal result;

            for (int i = 0; i < integers.Count; i++)
            {
                result = integers[i] / input;
                Console.WriteLine(integers[i] + " / " + input + " = " + result);

            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Sorry, you cannot divide any number by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        finally
        {
            Console.WriteLine("\nDo you want to try again?");
            Console.ReadLine();
        }
       
    }
    }
