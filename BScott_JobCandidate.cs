/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #5 with C# - Create a simple program that uses a switch 
 * statement; the statement will take the number of years of experience and go through the
 * switch statement loop; switch statements are like if statements but more specialized.
 */

//Preprocessor Directives
using System;

//namespace statement
namespace JobCandidate
{
    //main class
    class MainClass
    {
        //main function
        public static void Main(string[] args)
        {
            //print question on console
            Console.WriteLine("How many years of experience do you have?");

            //int.parse takes the input and turns it into an integer
            var years = int.Parse(Console.ReadLine());

            //switch statement which will verify through each case and break so that
            //it will not loop
            switch (years)
            {
                //Case for 0 years experience
                case 0:
                    //print inexperienced
                    Console.WriteLine("Inexperienced.");
                    //break
                    break;

                //Case for 1 year experience
                case 1:
                    //print junior
                    Console.WriteLine("Junior.");
                    //break
                    break;

                //Case for 2 years experience
                case 2:
                    //print intermediate
                    Console.WriteLine("Intermediate.");
                    //break
                    break;

                //Case for 3 years experience
                case 3:
                    //print advanced
                    Console.WriteLine("Advanced.");
                    //break
                    break;

                //Case for 4+ years experience
                default:
                    //print senior
                    Console.WriteLine("Senior.");
                    //break
                    break;
            }
        }
    }
}
