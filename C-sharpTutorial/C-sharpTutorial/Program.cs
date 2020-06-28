using System;

namespace C_sharpTutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            int[] luckyNumbers = { 1, 2, 3, 4 };

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(luckyNumbers[index]);

            string[] friends = new string[10];
            friends[0] = "Dung";
            friends[2] = "Duong";
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[2]);

            Console.ReadLine();

        }

    }
}
