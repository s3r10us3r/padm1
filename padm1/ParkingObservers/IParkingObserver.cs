namespace padm1;

public interface IParkingObserver
{
    public void Notify(Car car, int price);
}