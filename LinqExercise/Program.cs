﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());

            


            //TODO: Print the Average of numbers
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine();
            Console.WriteLine();
            var orderedNumbers= numbers.OrderBy(number => number);
            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine();
            Console.WriteLine();
            var orderNumbersBackwards = numbers.OrderByDescending(number => number);
            foreach(var number in orderNumbersBackwards)
            {
                Console.WriteLine(number);
            }

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine();
            Console.WriteLine();
            var greaterThanSix = numbers.Where(number => number > 6);
           foreach(var number in greaterThanSix) { Console.WriteLine(number); } 
           
            
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine();
            Console.WriteLine();
            foreach(var item in orderedNumbers.Take(4))
            {
                Console.WriteLine(item);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine();
            Console.WriteLine();
            numbers[3] = 38;
            foreach (var number in orderNumbersBackwards)
            {
                Console.WriteLine(number);
            }





            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine();
            Console.WriteLine();
            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's');

            foreach(var person in filtered) 
            {
                Console.WriteLine(person.FullName); 
            }



            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine();
            Console.WriteLine();
            var overTwentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var human in overTwentySix)
            {
               Console.WriteLine($"Full name: {human.FullName} Age: {human.Age}");
            }
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine();
            Console.WriteLine();
            var avgYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"The sum of work experience: {avgYOE.Sum(x => x.YearsOfExperience)}");
           

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine($"The average work experience: {avgYOE.Average(x => x.YearsOfExperience)}");


            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine();
            Console.WriteLine();
            var newEmployee = employees.Append(new Employee("Amy", "Galbicsek", 38, 3)).ToList();
          

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
