namespace padm1;

public class ParkingMailObserver : IParkingObserver
{
    public void Notify(Car car, int price)
    {
        Console.WriteLine("Sent mail about car");
    }
}