using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecotatorPattern
{
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
            Console.WriteLine(10 + base.GetPrice());
        }

        public GiftPacking Gift( int valor )
        {
            return giftPacking;
        }
    }
}
