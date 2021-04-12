/*
 * Name: Brianna Scott
 * Date: 04/11/2021
 * Purpose: Challenge #1 with C# - Create a simple three-question survey 
 * and output the answers back into the console
 */

//Preprocessor Directives
using System;

//namespace statement
namespace Survey
{
    //Main Class
    class MainClass
    {
        //Main Function
        public static void Main(string[] args)
        {
            //write "What is your name?" on console
            Console.WriteLine("What is your name? ");
            //Print name inside the console
            var name = Console.ReadLine();

            //Print age inside the console
            Console.WriteLine("What is your age? ");
            var age = Console.ReadLine();

            //Print birthdate inside the console
            Console.WriteLine("When is your birthday? ");
            var birthDate = Console.ReadLine();

            //Output Answers back into the console
            Console.WriteLine("Your name is {0}.", name);
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("Your Birthday is {0}.", birthDate);
        }
    }
}
