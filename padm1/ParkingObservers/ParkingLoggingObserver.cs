namespace padm1;

public class ParkingLoggingObserver : IParkingObserver
{
    public void Notify(Car car, int price)
    {
        Console.WriteLine($"Added new car {car.Brand} {price}");
    }
}