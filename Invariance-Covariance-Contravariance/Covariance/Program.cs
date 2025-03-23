namespace Covariance;

public class Program
{
    static void Main(string[] args)
    {
        // Covariance -  We can switch from Child (Derived) type to Parent (Base) type.
        ICar<Car> car = new BMW();

        Console.WriteLine(car.Drive());

        List<BMW> bMWs = new List<BMW>();
        IEnumerable<BMW> values = bMWs;
        IEnumerable<Car> car1 = bMWs;

        Console.WriteLine("Hello, World!");
    }
}
