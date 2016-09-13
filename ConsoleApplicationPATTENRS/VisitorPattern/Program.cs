using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main( string[] args )
        {
            TaxVisitor taxCal = new TaxVisitor();

            Necesity milk = new Necesity(3.47f);
            Liquor vodka = new Liquor(10f);
            Tabacco cigars = new Tabacco(12f);

            Console.WriteLine(milk.Accept(taxCal));
            Console.WriteLine(vodka.Accept(taxCal));
            Console.WriteLine(cigars.Accept(taxCal));

            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static double Format(this double item)
        {
            return Convert.ToDouble(
                String.Format("{0:00.0}",item));
        }
    }


    public interface IVisitor
    {
         double Visit( Liquor liquorItem);
         double Visit( Tabacco tabaccoItem );
         double Visit( Necesity necessityItem );
    }

    public interface IVisible
    {
        double Accept( IVisitor visitor );
    }
    public class Liquor:IVisible 
    {
        private double price;
       public Liquor(double item)
        {
            price = item;
        }
        
        public double GetPrice()
        {
            return price;
        }

        public double Accept( IVisitor visitor )
        {
            return visitor.Visit(this);
        }
    }

    public class Tabacco:IVisible
    {
        private double price;
        public Tabacco( double item )
        {
            price = item;
        }
        public double GetPrice( )
        {
            return price;
        }

        public double Accept( IVisitor visitor )
        {
            return visitor.Visit(this);
        }
    }

    public class Necesity:IVisible
    {
        private double price;
        
        public Necesity( double item )
        {
            price = item;
        }
        public double GetPrice( )
        {
            return price;
        }

        public double Accept( IVisitor visitor )
        {
            return visitor.Visit(this);
        }
    }

    public class TaxVisitor:IVisitor
    {
        public double Visit( Necesity necessityItem )
        {
            Console.WriteLine("Necesity item : Price with Tax");
            return (necessityItem.GetPrice() * 0f
                + necessityItem.GetPrice()).Format();
        }

        public double Visit( Tabacco tabaccoItem )
        {
            Console.WriteLine("Tabacco item : Price with Tax");
            return (tabaccoItem.GetPrice() * .32f 
                + tabaccoItem.GetPrice()).Format();
        }

        public double Visit( Liquor liquorItem )
        {
            Console.WriteLine("Liquor item : Price with Tax");
            return (liquorItem.GetPrice() * .18f 
                + liquorItem.GetPrice()).Format();
        }
    }
}
