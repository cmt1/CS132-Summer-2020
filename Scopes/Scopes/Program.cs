﻿using System;

namespace Scopes
{
    class Program
    {
        public static string Str2;
        static void ReturnString(string Str1)
        {
             Str2 = "Programming in C#";

            Console.WriteLine(Str1);
            
        }
        static void Main(string[] args)
        {
            ReturnString("CS132 ");
            Console.WriteLine(Str2);
        }
    }
}
