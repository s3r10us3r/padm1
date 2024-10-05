namespace padm1;

public interface ICarIterator
{
    Car CurrentElement { get; }
    Car GetNext();
    bool HasMore();
}