﻿using System;


namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns]; //create a 2D array tha is 3x3 (3 rows and 3 columns)
            table[0, 0] = 1; //asign value to wach array element, no specific value is ExtenderProvidedPropertyAttribute, by default its 0
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 1] = 5;
            table[2, 1] = 8;

            //loop through and print the whole 2D array
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)

                {
                    Console.WriteLine(table[x, y]);
                }

                Console.WriteLine(); //a new line is created after each row is iterated
            }
        }
    }
}
