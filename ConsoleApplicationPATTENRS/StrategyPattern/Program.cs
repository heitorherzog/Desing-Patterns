using DuckStuff;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main( string[] args )
        {
            Duck model = new ModelDuck();

            model.PerformQuack();
            model.setFlyBehavior(new FlyWithWings());
            model.PerformFly();

            //fazendo de forma diferente
            Console.WriteLine("\nPerformBehavior");
            model.PerformBehavior(DuckBehavior.FlyRockectPowered);
            model.PerformBehavior(DuckBehavior.FlyNoWay);
           

            Console.ReadLine();
        }
    }
}


