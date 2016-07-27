using System;
namespace DuckStuff
{
  public  class Mallard:Duck
    {
        public Mallard( )
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        protected override void Display( )
        {
            Console.WriteLine("I'am realMmallard duck");
        }
    }
}
