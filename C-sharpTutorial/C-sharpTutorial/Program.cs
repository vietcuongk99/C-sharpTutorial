using System;

namespace C_sharpTutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int index1 = 1;
            int index2 = 6;
            
            while (index1 <= 5)
            {
                Console.WriteLine(index1);
                index1++;
            }


            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index2 <= 5);


        }
       

    }
}
