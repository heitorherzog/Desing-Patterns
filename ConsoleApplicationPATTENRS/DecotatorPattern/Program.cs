using System;

namespace DecotatorPattern
{
    class Program
    {
        static void Main( string[] args )
        {
            //jeito 1
            Console.WriteLine("jeito 1 valores separados");
            Item book = new Book(1);
            book.Diplay();
            Item international = new GiftPacking(book);
            international.Diplay();

            //jeito 2
            Console.WriteLine("\njeito 2 valores somados");
            new GiftPacking(
                    new InternationalDelivery(book))
                    .Diplay();

            Console.WriteLine("\njeito 3 valores somados com func");

            //testando com funções
            Func<int,int> gift = value => value + 10;
            Func<int,int> taxes = value => value + 20;

            Console.WriteLine(gift.AndThen<int,int>(taxes).Invoke(book.GetPrice()));

            Console.Read();
        }
    }
}



