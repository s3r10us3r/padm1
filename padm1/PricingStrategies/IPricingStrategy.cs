namespace padm1;

public interface IPricingStrategy
{
    int Price(Car car, List<Car> cars);
}