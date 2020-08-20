using System;

namespace Date_Time
{
    class Program
    {
        void GetPersonalInfo()
        {
            Console.WriteLine("Enter Your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);

            Console.WriteLine("Here are what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);

            //Challenge
            int daysNum = 31;
            DateTime dt = DateTime.Now;
            Console.Write(dt.ToString("MM" + " "));
            Console.Write(dt.ToString(daysNum + " "));
            Console.ReadLine();

        }
        static void Main(string[] ags)
        {
            Program MyProgram = new Program();

            MyProgram.GetPersonalInfo();
        }
    }
}
