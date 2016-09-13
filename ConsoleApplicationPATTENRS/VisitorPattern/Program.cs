using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main( string[] args )
        {

        }
    }


    public interface IVisitor
    {
         double Visit( Liquor liquorItem);
         double Visit( Tabacco tabaccoItem );
         double Visit( Necesity necessityItem );

    }

    public class TaxVisitor:IVisitor
    {
        public double Visit( Necesity NecessityItem )
        {
            Console.WriteLine("Necesity item : Price with Tax");
            return necessityItem.GetPrice() * .18f + necessityItem.GetPrice();
        }

        public double Visit( Tabacco tabaccoItem )
        {
            Console.WriteLine("Tabacco item : Price with Tax");
            return tabaccoItem.GetPrice() * .18f + tabaccoItem.GetPrice();
        }

        public double Visit( Liquor liquorItem )
        {
            Console.WriteLine("Liquor item : Price with Tax");
            return liquorItem.GetPrice() * .18f + liquorItem.GetPrice();
        }
    }
}
