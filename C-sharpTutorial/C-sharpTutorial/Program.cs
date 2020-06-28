using System;

namespace C_sharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your number you want to show: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your quote you like: ");

            string quote = Console.ReadLine();

            Console.WriteLine(number + "\n" + quote);
            
        }

    }
}
