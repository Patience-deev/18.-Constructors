using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    class book
    {
        public string title;
        public string author;
        public int pages;

        public book(string atitle, string aAuthor, int aPages) 
        {
            title = atitle;
            author = aAuthor;
            pages = aPages;

        }
        static void Main(string[] args)
        {
            book book1 = new book("harry porter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
