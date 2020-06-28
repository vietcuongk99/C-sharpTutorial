using System;

namespace C_sharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32("12");

            Console.WriteLine(num + 12);


            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total " + (num1 + num2));

            Console.WriteLine("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total " + (num3 + num4));

        }

    }
}
