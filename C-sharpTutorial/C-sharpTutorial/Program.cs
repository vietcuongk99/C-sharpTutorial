using System;

namespace C_sharpTutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            getTotal(num1, num2);


        }

        static void getTotal(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

    }
}
