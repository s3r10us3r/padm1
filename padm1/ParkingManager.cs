namespace padm1;

public class ParkingManager
{
    public static ParkingManager Instance => _instance ??= new ParkingManager(); 
    private static ParkingManager? _instance;

    private ParkingManager()
    {
    }
    
    private List<Car> cars = [];
    private List<IParkingObserver> observers = [];
    private IPricingStrategy _pricingStrategy = new FlatPricingStrategy();
    
    public int AddCar(Car car)
    {
        cars.Add(car);
        var price = _pricingStrategy.Price(car, cars);
        foreach (var obs in observers)
            obs.Notify(car, price);
        return price;
    }

    public void AddObserver(IParkingObserver observer)
    {
        observers.Add(observer);
    }

    public void SetPricingStrategy(IPricingStrategy pricingStrategy)
    {
        _pricingStrategy = pricingStrategy;
    }
    
    public ICarIterator HpIterator => new HpIterator(cars);
    public ICarIterator RegularIterator => new RegularIterator(cars);
}