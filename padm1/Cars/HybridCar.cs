namespace padm1;

public class HybridCar : Car
{
    private enum HybridMode
    {
        Electric,
        Gasoline
    }

    private HybridMode Mode { get; set; } = HybridMode.Electric;
    
    public HybridCar(string brand, int hp, string color) : base(brand, hp, color)
    {
    }

    public void SwitchMode()
    {
        Mode = Mode == HybridMode.Electric ? HybridMode.Gasoline : HybridMode.Electric;
        Console.WriteLine("Switched mode to " + Mode);
    }
}