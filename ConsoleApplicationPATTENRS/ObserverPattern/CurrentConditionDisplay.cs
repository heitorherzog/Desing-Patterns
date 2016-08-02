using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject WeatherData;

        public CurrentConditionDisplay( Subject WeatherData )
        {
            this.WeatherData = WeatherData;
            WeatherData.RegisterObserver(this);
        }

        public void Display( )
        {
            Console.WriteLine(
                string.Format("Current conditions {0} F and humidity {1} % "
                , temperature, humidity));
        }

        public void Update( float temp, float humidity, float pressure )
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

      

      
    }
}
