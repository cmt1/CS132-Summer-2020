using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[5]; //creating a new array of type interger named 'numbers/
          //  numbers[0] = 1;
          //  numbers[1] = 2;
          //  numbers[2] = 3;
          //  numbers[3] = 4;
          //  numbers[4] = 5;

            //print out the whole array
            //for (int i = 0; i < numbers.Length; i++)
           // {
           //     Console.WriteLine(numbers[i] + " ");
           // }
           //foreach (int number in numbers)
           // {
                //    Console.Write(number + " ");
                // }

                string[] sentence = new string[4];
              sentence[0] = "This";
              sentence[1] = "is";
              sentence[2] = "a";
              sentence[3] = "string";
          

            for (int i = 0; i < sentence.Length; i++)
                {
                    Console.WriteLine(sentence[i] + " ");
                }
        }
    }
}
