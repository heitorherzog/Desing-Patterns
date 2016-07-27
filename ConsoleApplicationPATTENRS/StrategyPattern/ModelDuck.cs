using System;
namespace DuckStuff
{
    public class ModelDuck:Duck
    {
        public ModelDuck( )
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        protected override void Display( )
        {
            Console.WriteLine("I am a model Duck");
        }
    }
}
