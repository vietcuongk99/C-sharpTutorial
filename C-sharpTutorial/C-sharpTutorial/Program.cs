using System;

namespace C_sharpTutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string secretWord = "cuong";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outofGuesses = false;

            while (guess != secretWord && !outofGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outofGuesses = true;
                }
                

            }

            if(outofGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You win!");
            }

            


        }
       

    }
}
