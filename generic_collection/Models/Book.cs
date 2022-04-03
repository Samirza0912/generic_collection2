using System;
using generic_collection.Helper;

namespace generic_collection.Models
{
    public class Book : Product
    {
        /*Book class (Product-dan miras alır)
  - AuthorName
  - PageCount
        ShowInfo methodunu override edir və bütün book-un məlumatlarını console-a çıxardır.
Sell methodunu override edir və hər dəfə sell methodu işə düşəndə bir ədəd book satılmalıdır
        count azalır TotalInCome isə artır,
        əgər Product-ın count-ı sıfır olarsa o zaman ProductCountIsZeroException baş versin və satış baş verməsin.

ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.

         */

        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string authorname, int pagecount)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }


        public override void Sell()
        {
            if (Count==0)
            {
                throw  ProductCountIsZero();
                
            }
            else
            {
                Count--;
                TotalIncome++;
            }
        }

        private Exception ProductCountIsZero()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            Console.Write($"{id}; {Name}; {AuthorName}; {Count}; {PageCount}; {Price}; {TotalIncome}");
        }
    }
}
