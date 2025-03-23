namespace Contravariance;

public class Engine<T> : ICar<T> where T : Car
{
    public string Drive()
    {
        return "Driving Engine";
    }
}
