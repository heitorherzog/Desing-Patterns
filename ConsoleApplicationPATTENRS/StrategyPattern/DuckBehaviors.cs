using System;

namespace DuckStuff
{
    class FlyWithWings:FlyBehavior
    {
        public void Fly( )
        {
            Console.WriteLine("I am flying!");
        }
    }

    class FlyNoWay:FlyBehavior
    {
        public void Fly( )
        {
            Console.WriteLine("I can't fly!");
        }
    }

    class Quack:QuackBehavior
    {
        void QuackBehavior.Quack( )
        {
            Console.WriteLine("Quack");
        }
    }

    class MuteQuack:QuackBehavior
    {
        public void Quack( )
        {
            Console.WriteLine(" << Silence >>");
        }
    }

    class Squeak:QuackBehavior
    {
        public void Quack( )
        {
            Console.WriteLine("Squeak ");
        }
    }

    class FlyRockectPowered:FlyBehavior
    {
        public void Fly( )
        {
            Console.WriteLine("I'm flying with rockect ");
        }
    }
}
