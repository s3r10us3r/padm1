namespace padm1;

public class ProgressivePricingStrategy : IPricingStrategy
{
    public int Price(Car car, List<Car> cars)
    {
        return (cars.Count + 1) * 50;
    }
}