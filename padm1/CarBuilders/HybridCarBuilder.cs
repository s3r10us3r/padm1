namespace padm1;

public class HybridCarBuilder : CarBuilder
{
    public override HybridCar Build()
    {
        return new HybridCar(_brand, _hp, _color);
    }
}