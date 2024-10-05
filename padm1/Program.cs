namespace padm1;

class Program
{
    static void Main(string[] args)
    {
        // Main logic remains the same as before
        var parkingManager = ParkingManager.Instance;
        parkingManager.AddObserver(new ParkingLoggingObserver());
        parkingManager.AddObserver(new ParkingMailObserver());

        var carBuilder = new CarBuilder();

        carBuilder.SetBrand("Lamborghini").SetColor("Yellow").SetHp(2000);
        var lamborghini = carBuilder.Build();
        parkingManager.AddCar(lamborghini);

        carBuilder.SetBrand("Fiat").SetColor("Red").SetHp(40);
        var fiat = carBuilder.Build();
        parkingManager.AddCar(fiat);

        parkingManager.SetPricingStrategy(new ProgressivePricingStrategy());

        carBuilder.SetBrand("Mercedes").SetColor("Black").SetHp(340);
        var mercedes = carBuilder.Build();
        parkingManager.AddCar(mercedes);

        Console.WriteLine();
        
        var regularIterator = parkingManager.RegularIterator;
        DisplayCarProperties(regularIterator);

        Console.WriteLine();
        
        var hpIterator = parkingManager.HpIterator;
        DisplayCarProperties(hpIterator);
    }

    public static void DisplayCarProperties(ICarIterator carIterator)
    {
        while (true)
        {
            try
            {
                Car car = carIterator.CurrentElement;
                Console.WriteLine($"Brand: {car.Brand}, HP: {car.Hp}, Color: {car.Color}");
                carIterator.GetNext(); // Move to the next element
            }
            catch
            {
                break;
            }
        }
    }
}