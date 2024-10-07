namespace padm1;

public class Car
{
    public string Brand { get; }
    public int Hp { get; }
    public string Color { get; }

    public Car(string brand, int hp, string color)
    {
        Brand = brand;
        Hp = hp;
        Color = color;
    }

    public void Honk()
    {
        Console.WriteLine("Honk honk!");
    }
}