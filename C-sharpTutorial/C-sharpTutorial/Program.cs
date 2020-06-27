using System;

namespace C_sharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "Dinh Viet Cuong " + "is Uet-er";
                          
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("viet"));
            Console.WriteLine(phrase.Contains("Cuong "));
            Console.WriteLine(phrase[phrase.Length - 8]);
            Console.WriteLine(phrase.IndexOf("Cuong"));
            Console.WriteLine(phrase.Substring(8, 10));

        }
    }
}
