namespace Covariance;

public class BMW : Car, ICar<BMW>
{
    public BMW DriveProp => throw new NotImplementedException();

    public string Drive()
    {
        return "Driving BMW";
    }
}
