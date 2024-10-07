namespace padm1;

public class SelfDrivingCarBuilder : CarBuilder
{
    public override SelfDrivingCar Build()
    {
        return new SelfDrivingCar(_brand, _hp, _color);
    }
}