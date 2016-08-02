using DuckStuff;
using System;

namespace StrategyPattern
{

    class Program
    {
        static void Main( string[] args )
        {
            Duck mallard = new Mallard();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.setFlyBehavior(new FlyRockectPowered());
            model.PerformFly();
        }
    }
}


