using System;
using System.Collections;
using System.Collections.Generic;

namespace generic_collection.Models
{
    public class Library
    {
        /*Library class
 - BookLimit
 - Books - List olacaq
 - AddBook() - Parametr olaraq bir Book obyekti qəbul edir
        və books listinə əlavə edir əgər BookLimiti aşırsa geriyə CapacityLimitException qaytarsın
 - GetBookById() - Parametr olaraq nullable bir id qəbul edir
        və o Book obyektini tapıb geriyə qaytarır əgər id null olarsa geriyə NullReferenceException qaytarsın
        ümumiyyətlə göndərilən id-li book-u tapmasa geriyə null qaytarsın.
 - RemoveById() - Parametr olaraq nullable bir id qəbul edir
        və o Book obyektini tapıb Books listindən silir
        əgər id null olarsa geriyə NullReferenceException qaytarsın
        ümumiyyətlə göndərilən id-li book-u tapmasa geriyə NotFoundException qaytarsın.

         */

        public int BookLimit { get; set; }
        List<int> books = new List<int>();

        public void AddBook(int book)
        {
            books.Add(book);
        }

        public void GetBookById(int? Id)
        {
            int? id = null;
            Id = id;
        }

        public void RemoveById(int? Id)
        {

        }

    }
}
