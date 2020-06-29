using System;

namespace C_sharpTutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 < 0 || num2 < 0)
            {
                Console.WriteLine("One of two inputs is negative integer");
                Console.WriteLine(getTotal(num1, num2));
            } 
  
            else
            {
                Console.WriteLine(getTotal(num1, num2));
            }
             


        }

        static int getTotal(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }

    }
}
