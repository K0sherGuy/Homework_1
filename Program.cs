using System;

namespace UserPin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter PIN:");
            string PIN = Console.ReadLine();

            if (PIN == "1234")

            {
                Console.WriteLine("Please enter your Name:");
                string UserName = Console.ReadLine();
                Console.WriteLine("Hello" + " " + UserName);
            } else

            {
                Console.WriteLine("Invalid PIN");
            }
        }
    }
}
