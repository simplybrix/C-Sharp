/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #6 with C# - Create a simple program that recieves student
 * name and grade via input; it will handle any number of students and finally,
 * display all student names and grades once the user is finish inputting them.
 * Bonus: find and print the mean studentGrades.
 */

//Preprocessor directives
using System;
using System.Collections.Generic;

//namespace statement
namespace StudentManager
{
    //main class
    class MainClass
    {
        //main function
        public static void Main(string[] args)
        { 
            //create two arrays called student names and grades
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            //adding will help add a new student
            bool adding = true;

            //while loop: ask the teacher for the student names
            while (adding)
            {
                //print student name and wait for input
                Console.WriteLine("Student Name: ");
                studentNames.Add(Console.ReadLine());

                //print student grades and wait for input
                Console.WriteLine("Student Grade:");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                //ask user if they wish to add more students
                Console.WriteLine("Do you wish to add another student? y/n");

                //if statement: if the answer does not equal yes, the loop will
                //break
                if(Console.ReadLine() != "y")
                {
                    //break loop
                    adding = false;
                }
            }

            //while loop: used to print student names and grades
            for (int i = 0; i < studentNames.Count; i++)
            {
                //Prints student names and grades
                Console.WriteLine("Student Name: {0}, Student Grade: {1}%", studentNames[i], studentGrades[i]);
            }

            //Bonus: Find the mean of the studentGrades and print it
            //add mean
            int sum = 0;
            for (int i = 0; i < studentGrades.Count; i++)
            {
                //solve sum
                sum += studentGrades[i];
            }

            //find the mean
            var mean = sum / studentGrades.Count;
            //print mean value
            Console.WriteLine("The mean of the students' grades is {0}%.", mean);
        }
    }
}
