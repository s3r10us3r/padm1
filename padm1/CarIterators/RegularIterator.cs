namespace padm1;

public class RegularIterator : ICarIterator
{
    private readonly Car[] _cars;
    private int pointer = 0;
    
    public RegularIterator(IList<Car> cars)
    {
        _cars = cars.ToArray();
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