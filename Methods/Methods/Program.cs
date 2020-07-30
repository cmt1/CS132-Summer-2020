using System;
using System.Runtime.InteropServices;

namespace Methods
{
    class Program
    {
        //Method called Mod that takes in 2 parameters
        //both of type interger
        
        public static int Mod(int a, int b)
        {
            //the passes in intergers are divided
            //and the result is stored in the integer "modulus"
            
             //return the values stored in "modulus"

            int modulus = a % b;
            return modulus;
        }
        //Method called "Main",
        //Called whent the program is ran
        static void Main(string[] args)
        {
            // call methid "Adding" and pass in 2 parameter: 20 and 13
            //print the results of method "Mod"
           
            Console.WriteLine(Mod(20, 13));
        }
    }
}
