using System.Collections;

public class WeatherData:Subject
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
        for(int i = 0;i < observers.Count;i++)
        {
            Observer observer = (Observer)observers[i];
            observer.Update(temperature,humidity,pressure);
        }
    }

    public void RegisterObserver( Observer o )
    {
        observers.Add(o);
    }

    public void RemoveObserver( Observer o )
    {
        int i = observers.IndexOf(o);
        if(i >= 0)
            observers.Remove(i);
    }

    public void MeasurementsChanged( )
    {
        NotifyObservers();
    }

    public void SetsurementsChange(float temperature,
        float humidity, float pressure )
    {
        this.humidity = humidity;
        this.temperature = temperature;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}
