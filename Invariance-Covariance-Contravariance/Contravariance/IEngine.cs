namespace Contravariance;

public class Engine<T> : ICar<T> where T : Car
{
    public T DriveProp { set => throw new NotImplementedException(); }

    public string Drive()
    {
        return "Driving Engine";
    }

    public void Drive(T car)
    {
        throw new NotImplementedException();
    }
}
