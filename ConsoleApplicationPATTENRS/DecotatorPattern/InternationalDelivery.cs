using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecotatorPattern
{
    public class InternationalDelivery:ItemExtras
    {
        public InternationalDelivery( Item item ) : base(item) { }

        public override int GetPrice( )
        {
            return base.GetPrice() + 20;
        }

        public override void Diplay( )
        {
            Console.WriteLine(20 + base.GetPrice());
        }
    }
}
