public interface Subject
{
    void NotifyObservers( );
    void RegisterObserver( Observer o );
    void RemoveObserver( Observer o );
}