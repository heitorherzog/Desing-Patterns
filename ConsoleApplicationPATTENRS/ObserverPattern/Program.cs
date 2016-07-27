using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main( string[] args )
        {
            WeatherData w = new WeatherData();

            CurrentConditionDisplay c = 
                new CurrentConditionDisplay(w);

            w.SetsurementsChange(80f,65f,30.4f);
            w.SetsurementsChange(82f,70f,29.2f);
            w.SetsurementsChange(80f,90f,39.2f);


            Console.ReadLine();
          
        }
    }
}


