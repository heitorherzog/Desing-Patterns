using System;

namespace DuckStuff
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        protected abstract void Display( );

        public void PerformFly( )
        {
            flyBehavior.Fly();
        }

        public void PerformQuack( )
        {
            quackBehavior.Quack();
        }

        public void Swim( )
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehavior( FlyBehavior fb )
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior( QuackBehavior qb )
        {
            quackBehavior = qb;
        }

    }
}
