using System;
using System.Collections;
using generic_collection.Models;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(80); 


            Book book1 = new Book("Bukayo", 1234, "Saka", 23);
            Book book2 = new Book("Emil", 321, "Smith-Rowe", 43);
            Book book3 = new Book("Martin", 234, "Odegaard", 21);
            Book book4 = new Book("Gabriel", 999, "Martinelli", 111);
            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            library.GetBookById(3);

            library.RemoveById(1);


            book1.Sell();
            book2.ShowInfo();

        }
    }
}
