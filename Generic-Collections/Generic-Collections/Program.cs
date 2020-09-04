using System;
using System.Collections;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable()
            {
                {"Kim", 26 },
            { "John", 77},
                {"Max", 50}
            };

            int HashTableVal1 = (int)myHashTable["Kim"];
            int HashTableVal2 = (int)myHashTable["John"];
            int HasshTableVal3 = (int)myHashTable["Max"];

            Console.WriteLine(HashTableVal1);
            Console.WriteLine(HashTableVal2);
            Console.WriteLine(HasshTableVal3);

        }
    }
}
