using System;
using generic_collection.Helper;

namespace generic_collection.Models
{
    public abstract class Product:Exceptions
    {
        /*- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq 
         * və hər dəfə yeni bir Book obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Price
- Count
- TotalInCome - book satışlarından alınan gəlir sadəcə Productın miras verdiyi class-larda set etmək olar
- Sell() - abstrakt method olacaq
- ShowInfo() - abstrakt method olacaq
         */
        private static int _Id;
        
        public int id { get; }

        public string Name { get; set; }
        public int Price { get; set; }
        public static int Count { get; set; }
        public int TotalIncome { get; set; }

        public Product(string name, int price, int count, int totalincome):base()
        {
            Name = name;
            Price = price;
            Count = count;
            TotalIncome = totalincome;
            _Id = id;
            _Id++;
        }
        public abstract void Sell();
        public abstract void ShowInfo();
        public Product()
        {

        }
         
        

        
        

        
    }
}
