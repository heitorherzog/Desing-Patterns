using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            Func<int,int> inter = value => value + 15;

            Func<int,int> times2 = e=>e * 2;
            Func<int,int> squared = e=>e * e;

            Console.WriteLine(times2.Compose(squared).Invoke(4)); //32
            Console.WriteLine(times2.AndThen(squared).Invoke(4)); //64

            Console.WriteLine(gift.AndThen(taxes).Invoke(book.GetPrice()));
            Console.WriteLine(gift.AndThen(taxes).AndThen(inter).Invoke(book.GetPrice()));

            Console.WriteLine("\nTestando com arrays");
            Func<int,int>[] blah = { times2, squared,taxes,inter,gift };
            var retorno = blah.Aggregate(( x,y ) => x.AndThen(y)).Invoke(4);
            Console.WriteLine(retorno);

           Console.Read();
        }
    }
}



