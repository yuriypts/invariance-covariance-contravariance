namespace Invariance;

public interface ICar<T> where T : Car
{
    string Drive();
}
