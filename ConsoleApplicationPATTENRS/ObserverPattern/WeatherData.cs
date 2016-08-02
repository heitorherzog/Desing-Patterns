using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData( )
        {
            observers = new ArrayList();
        }

        public void NotifyObservers( )
        {
            for (int i = 0; i <  observers.Count; i++)
            {
                Observer o = (Observer)observers[i];
                o.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements( float temp, float hum, float pressu )
        {
            temperature = temp;
            humidity = hum;
            pressure = pressu;

            MeasurementsChanged();
        }

        public void RegisterObserver( Observer o )
        {
            observers.Add(o);
        }

        public void RemoveObserver( Observer o )
        {
            observers.Remove(observers.IndexOf(o));
        }
    }
}
