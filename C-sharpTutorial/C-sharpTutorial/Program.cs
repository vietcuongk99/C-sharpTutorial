using System;

namespace C_sharpTutorial
{
    class Program
    {
            
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            book2.title = Console.ReadLine();
            book2.author = Console.ReadLine();
            book2.pages = Convert.ToInt32(Console.ReadLine());

            book1.Type = "novel";

            Console.WriteLine(book1.title + '\n' + book2.title + '\n'+ book1.Type);

            Console.WriteLine(book1.HasTitle());
           
        }
       

    }
}
