using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("Guess a number (1-10): ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //recieve user input ans store in "userInput" cariable
            //Challenge
            if (userInput <= num)
            {
                Console.WriteLine("Your guess was correct!");
            }
            else
            {
                Console.WriteLine("Number must be between 1-10!!!");
            }
            }
        }
    }

