/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #2 with C# - Create a simple program that asks for a passcode 
 * "secret"; if passcode is correct, let the user know they are authenticated
 * bonus: if not authenticated, print not granted and give another try
 */

//Preprocessor Directives
using System;

//namespace statement
namespace Passcode
{
    //main class
    class MainClass
    {
        //main function
        public static void Main(string[] args)
        {
            //declare passcode 
            var passcode = " ";
            while (passcode != "secret")
            {
                //Ask for passcode
                Console.WriteLine("Enter the passcode:");

                //get input and store in passcode
                passcode = Console.ReadLine();

                //if it equals another word, access not granted
                if (passcode != "secret")
                {
                    //access denied
                    Console.WriteLine("Access Denied. Please try again.");
                }
            }
            //if correct, you are authenticated
            Console.WriteLine("You have been authenticated. Welcome!");
        }
    }
}
