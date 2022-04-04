using System;
using System.Collections;
using generic_collection.Models;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Library student = new Library();
            Book book = new Book("Bukayo Saka", 125);
            Book book1 = new Book("Smith Row", 666);
            Book book2 = new Book("George Ornwell", 1234);
            Book book3 = new Book("Lev Tolstoy", 10000);
            book.Sell();
            book1.Add();
            student.ShowInfo();
            student.GetBookById();
            student.RemoveById();
        }
    }
}
