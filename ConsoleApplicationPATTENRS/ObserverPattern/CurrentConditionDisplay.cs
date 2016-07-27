using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CurrentConditionDisplay:Observer, DisplayElement
{
    private float temperature;
    private float humidity;
    private float pressure;
    private Subject weatherData;

    public CurrentConditionDisplay(Subject weatherData )
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display( )
    {
        Console.WriteLine("Current conditions "
            + temperature + "F degrees and "
            + humidity + " % humidity");
    }

    public void Update( float temperature,float humidity,float pressure )
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }
}

