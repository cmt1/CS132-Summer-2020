using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS132";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i = i+2) //Challenge
            {
              

                
               
                     
                Console.WriteLine(message[i]);
            }
           
        }
    }
}
