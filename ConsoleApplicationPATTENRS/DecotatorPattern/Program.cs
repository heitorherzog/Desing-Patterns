using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecotatorPattern
{
    public static class LambdaExtensios
    {
        public static Action<T> AndThen<T>( this Action<T> first,Action<T> next )
        {
            return e => { first(e); next(e); };
        }
        //public static Action<T> AndThen<T>( this Func<T,T> first,Func<T,T> next )
        //{
        //    return e => { first(e); next(e); };
        //}
    }

    class Program
    {
        static void Main( string[] args )
        {
            Item book = new Book(10);
            //book.Diplay();

            //Item international = new GiftPacking(book);
            //international.Diplay();

            //new GiftPacking(
            //    new InternationalDelivery(book))
            //    .Diplay();

            Func<int,int> gift = value => value + 15;
            Func<int,int> taxes = value => value + 20;

            Action<int> a = (int x) =>  x + 1;
            Action<int> b = ( int x ) => {  };

            a.AndThen(b);








            Console.Read();
        }

        private static void method( int obj )
        {
            throw new NotImplementedException();
        }
    }


    public interface Item
    {
        int GetPrice( );
        void Diplay( );
    }

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

    public abstract class ItemExtras:Item
    {
        private Item item;

        public ItemExtras( Item item )
        {
            this.item = item;
        }

        public virtual int GetPrice( )
        {
            return item.GetPrice();
        }

        public virtual void Diplay( )
        {
            Console.WriteLine(item.GetPrice());
        }
    }

    public class GiftPacking:ItemExtras
    {
        private GiftPacking giftPacking;
        public GiftPacking( Item item ) : base(item) { giftPacking = this; }

        public override int GetPrice( )
        {
            return base.GetPrice() + 10;
        }

        public override void Diplay( )
        {
            Console.WriteLine( 10 + base.GetPrice());
        }

        public GiftPacking Gift(int valor)
        {
            return giftPacking;
        }
    }

    public class InternationalDelivery:ItemExtras
    {
        public InternationalDelivery( Item item ) : base(item) { }

        public override int GetPrice( )
        {
            return base.GetPrice() + 10;
        }

        public override void Diplay( )
        {
            Console.WriteLine( 10 + base.GetPrice());
        }
    }

}

