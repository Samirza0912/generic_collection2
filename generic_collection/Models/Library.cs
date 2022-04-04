﻿using System;
using System.Collections;
using System.Collections.Generic;
using generic_collection.Helper;

namespace generic_collection.Models
{
    public class Library:Product
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
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (books.Count>BookLimit)
            {
                throw CapacityLimitException();
            }
            else
            {
                books.Add(book);
            }
        }

        private Exception CapacityLimitException()
        {
            throw new NotImplementedException();
        }

        public void GetBookById(int? Id)
        {
            int? id = null;
            Id = id;
        }

        public void RemoveById(int? Id)
        {
            foreach (var item in books)
            {
                if (item.id == id)
                {            
                    books.Remove(item);
                    Console.WriteLine($"{item.id}; {item.Name}; {item.AuthorName}; {item.PageCount}; {item.Price}");
                    return;
                }
            }
            if (id == null)
            {
                throw  new NullReferenceException();
            }
            else
            {
                throw  NotFoundException();
            }

        }

        private Exception NotFoundException()
        {
            throw new NotImplementedException();
        }

        public override void Sell()
        {
            
        }

        public override void ShowInfo()
        {
            
        }

        internal void Add()
        {
            
        }

        internal void GetBookById()
        {
            
        }

        internal void RemoveById()
        {
            
        }
    }
}
