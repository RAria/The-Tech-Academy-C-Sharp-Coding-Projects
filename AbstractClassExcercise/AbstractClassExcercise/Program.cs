﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Employee object.
            // Employee Name = new Employee() {firstName = "Sample", lastName = "Student" };

            //call the method on instantiated object.
            // Name.SayName(Name.firstName, Name.lastName);
            //            Console.ReadLine();

            //Create an object of type interface. Since interface cannot be instantiated directly but using polymorphism -
            //we can create an object of the inheriting class which will have access to the properties of the interface.
            Employee quit = new Employee();
            quit.Quit();
            Console.Read();
        }
    }
}