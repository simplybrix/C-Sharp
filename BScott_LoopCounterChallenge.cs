/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #3 with C# - Create a simple for loop that counts from 1-10,
 * then back down to 1; repeats 5 times and output the answers back into the console
 * You cannot use if statements
 */

//Preprocessor Directives
using System;

//namespace statement
namespace Forloops
{
    //main class
    class MainClass
    {
        //main function
        public static void Main(string[] args)
        {
            for (int b = 1; b <= 5; b++)
            {
                //for loop: count to 10
                for (int i = 1; i <= 10; i++)
                {
                    //print i
                    Console.WriteLine(i);
                }
                //for loop: subtract 1
                for (int i = 10; i >= 1; i--)
                {
                    //print i
                    Console.WriteLine(i);
                }
            }
        }
    }
}
