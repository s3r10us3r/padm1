namespace padm1;

class Program
{
    static void Main(string[] args)
    {
        var parkingManager = ParkingManager.Instance;
        parkingManager.AddObserver(new ParkingLoggingObserver());
        parkingManager.AddObserver(new ParkingMailObserver());

        var carBuilder = new CarBuilder();
        var hybridCarBuilder = new HybridCarBuilder();
        var selfDrivingCarBuilder = new SelfDrivingCarBuilder();

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
        
        hybridCarBuilder.SetBrand("Toyota").SetColor("Green").SetHp(100);
        var toyota = hybridCarBuilder.Build();
        parkingManager.AddCar(toyota);
        toyota.SwitchMode();
        
        Console.WriteLine();
        
        selfDrivingCarBuilder.SetBrand("Tesla").SetColor("White").SetHp(500);
        var tesla = selfDrivingCarBuilder.Build();
        parkingManager.AddCar(tesla);
        tesla.ToggleAutopilot();
        
        Console.WriteLine();
        
        var regularIterator = parkingManager.RegularIterator;
        DisplayCarProperties(regularIterator);

        Console.WriteLine();
        
        var hpIterator = parkingManager.HpIterator;
        DisplayCarProperties(hpIterator);
        
        Console.WriteLine();
        
        toyota.SwitchMode();
        tesla.ToggleAutopilot();
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