/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Create a simple for loop and output the answers back into the console
 */

//Preprocessor Directives
using System;

//namespace statement
namespace ForLoop
{
    //Main class
    class MainClass
    {
        //Main function
        public static void Main(string[] args)
        {
            //for loop: i is less than or equal to 10, it will continue to count
            //until it reaches 10
            for (int i = 1; i <= 10; i++)
            {
                //print count
                Console.WriteLine(i);
            }
        }
    }
}
