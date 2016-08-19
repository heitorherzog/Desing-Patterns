using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecotatorPattern
{
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
}
