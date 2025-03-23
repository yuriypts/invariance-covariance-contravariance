namespace Invariance;

public class BMW : Car, ICar<BMW>
{
    public string Drive()
    {
        return "Driving BMW";
    }
}
