namespace padm1;

public class SelfDrivingCar : Car
{
    private bool AutopilotEnabled { get; set; }
    
    public SelfDrivingCar(string brand, int hp, string color) : base(brand, hp, color)
    {
    }
    
    public void ToggleAutopilot()
    {
        AutopilotEnabled = !AutopilotEnabled;
        Console.WriteLine("Autopilot has been " + (AutopilotEnabled ? "enabled" : "disabled"));
    }
}