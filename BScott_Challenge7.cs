/*
 * Name: Brianna Scott
 * Date: 04/12/2021
 * Purpose: Challenge #7 with C# - Create a simple survey and output the answers
 * back into the console
 */


//preprocessor directives
using System;

//namespace statement
namespace ChallengeSurvey
{
    //Data class
    class Data
    {
      //declare public string and integer values
        public string name;
        public int age;
        public string month;


        public void Display()
        {
            //Print responses and answers from input
            Console.WriteLine("Your name is {0}.", name);
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You were born in {0}.", month);

            //if statement: if the month equals March, print the zodiac sign
            if (month == "March")
            {
                Console.WriteLine("Your birth month is {0}, therefore, you're zodiac sign is Aries. Woohoo!", month);
            }

            //if statement: if the month equals April, print the zodiac sign
            else if (month == "April")
            {
                Console.WriteLine("Your birth month is {0}, therefore, you're zodiac sign is Taurus. Woohoo!", month);
            }

            //if statement: if the month equals May, print the zodiac sign
            else if (month == "May")
            {
                Console.WriteLine("Your birth month is {0}, therefore, you're zodiac sign is Gemini. Woohoo!", month);
            }
        }
    }

    //Program Class
    class Program
    {
        //main function
        public static void Main(string[] args)
        {
            //declare data variable
            var data = new Data();

            //Ask Question and wait for input
            Console.WriteLine("What is your name?");
            data.name = TryAnswer();

            //Ask Question and wait for input
            Console.WriteLine("What is your age?");
            data.age = int.Parse(TryAnswer());

            //Ask Question and wait for input
            Console.WriteLine("What month were you born in?");
            data.month = TryAnswer();

            //print Display class
            data.Display();

            //TryAnswer() function
             string TryAnswer()
            {
                //declare variable question and wait for input
                var question = Console.ReadLine();

                //if question equals space, print you didn't type anything and
                //give the user another try
                if(question == " ")
                {
                    //print the message to console
                    Console.WriteLine("You didn't type anything. Please try again.");

                    //return the input to console
                    return Console.ReadLine();
                }
                //return the value in question
                return question;
            }
        }
    }
}
