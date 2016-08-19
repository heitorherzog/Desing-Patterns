using System;

namespace DecotatorPattern
{
    public class Book:Item
    {
        private int price;
        public Book( int price )
        {
            this.price = price;
        }

        public void Diplay( )
        {
            Console.WriteLine(price);
        }

        public int GetPrice( )
        {
            return price;
        }

    }
}


