namespace padm1;

public class CarBuilder
{
    private string _brand;
    private int _hp;
    private string _color;

    public CarBuilder SetBrand(string brand)
    {
        _brand = brand;
        return this;
    }

    public CarBuilder SetHp(int hp)
    {
        _hp = hp;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        _color = color;
        return this;
    }

    public Car Build()
    {
        return new Car(_brand, _hp, _color);
    }
}