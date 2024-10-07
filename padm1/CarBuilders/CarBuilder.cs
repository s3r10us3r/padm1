namespace padm1;

public class CarBuilder
{
    protected string _brand;
    protected int _hp;
    protected string _color;

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

    public virtual Car Build()
    {
        return new Car(_brand, _hp, _color);
    }
}