using System;

namespace Generic_Collection
{
    class Program
    {
        class StoreAnything <T, U, V> 
        {
            public T var1 { set; get; }
            public U var2 { set; get; }

            //Challenge
            public V var3 { set; get; }
        }

        
        static void Main(string[] args)
        {
        StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> { var1 = "CS", var2 = 132, var3 = '!' };

           
            //Challenge added char
            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + " " + MyVar1.var3);
        }
    }
}
