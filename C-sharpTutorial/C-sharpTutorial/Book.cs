using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharpTutorial
{
    class Book
    {
        public string title;
        public int pages;
        public string author;
        private string type;

        public Book() { }

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string Type { 
            get { return type; } 
            set { type = value; } 
        }

        public bool HasTitle()
        {
            if(title == null)
            {
                return false;
            }

            return true;
        }


    }
}
