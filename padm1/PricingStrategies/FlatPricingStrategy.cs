namespace padm1;

public class FlatPricingStrategy : IPricingStrategy
{
    public int Price(Car car, List<Car> cars)
    {
        return 50;
    }
}