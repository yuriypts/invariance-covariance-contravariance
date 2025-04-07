namespace Contravariance;

public class BMW : Car, ICar<BMW>
{
    public BMW DriveProp { set => throw new NotImplementedException(); }

    public string Drive()
    {
        return "Driving BMW";
    }

    public void Drive(BMW car)
    {
        throw new NotImplementedException();
    }
}
