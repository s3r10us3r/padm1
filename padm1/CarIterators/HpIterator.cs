namespace padm1;

public class HpIterator : ICarIterator
{
    private int pointer = 0;
    private Car[] _cars;
    
    public HpIterator(IList<Car> cars)
    {
        _cars = cars.OrderBy(c => c.Hp).ToArray();
    }

    public Car CurrentElement => _cars[pointer];
    public Car GetNext()
    {
        if (HasMore())
            return _cars[++pointer];
        throw new IndexOutOfRangeException();
    }

    public bool HasMore()
    {
        return _cars.Length - 1 > pointer;
    }
}