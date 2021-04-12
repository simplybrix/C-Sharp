/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #4 with C# - Create a simple array for a school that tracks
 * it's students grades. For now, we will track one teacher's class of 10 students
 * and output the answers back into the console.
 */

//preprocessor directives
using System;

//namespace statement
namespace SchoolTracker
{
    //main class
    class MainClass
    {
        //main function
        public static void Main(string[] args)
        {
            //create an array called student grades
            var studentGrades = new int[10] { 100, 20, 25, 30, 90, 80, 77, 45, 80, 90};

            //print The teacher's student's grades are as follows: on console
            Console.WriteLine("The teacher's student's grades are as follows:");

            //For each loop: used to print all of the student's grades at once
            foreach (var studentGrade in studentGrades)
            {
                //print student grades on the screen
                Console.WriteLine(studentGrade);
            }
            //Bonus: Find the mean of the studentGrades and print it
            //add mean
            var mean = (studentGrades[0]+ studentGrades[1]+ studentGrades[2]+ studentGrades[3]+ studentGrades[4]+ studentGrades[5]+ studentGrades[6]+ studentGrades[7]+ studentGrades[8]+ studentGrades[9]) / 10;

            //print mean value
            Console.WriteLine("The mean of the students' grades is {0}%.", mean);
        }
    }
}
