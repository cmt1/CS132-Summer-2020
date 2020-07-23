using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are the variables set that we will be using in this method //
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            // We are using number variables to solve out numeric operations //
            float sum = num1 + num2 + num3; // will add all the varables
            int subtract = num2 - num1; // will subtract variables
            int multiply = num1 * num2; // will multiply our varaibles
            float divide = num1 / num3; // will divide out varibles and float the integer
            int modulus = num2 % num1; // will calculate variable percentage

            Console.WriteLine("Sum of 3 numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);

        }
    }
}
