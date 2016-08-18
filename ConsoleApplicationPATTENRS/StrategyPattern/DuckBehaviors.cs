using System;

namespace DuckStuff
{

    #region Behavior

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

    #endregion Behavior

    #region BehaviorStatic
    static class DuckBehavior
    {
        public static void FlyWithWings( )
        {
            Console.WriteLine("I am flying!");
        }

        public static void FlyNoWay( )
        {
            Console.WriteLine("I can't fly!");
        }

        public static void Quack( )
        {
            Console.WriteLine("Quack");
        }


        public static void MuteQuack( )
        {
            Console.WriteLine(" << Silence >>");
        }


        public static void Squeak( )
        {
            Console.WriteLine("Squeak ");
        }

        public static void FlyRockectPowered( )
        {
            Console.WriteLine("I'm flying with rockect ");
        }
    }
    #endregion BehaviorStatic


}
