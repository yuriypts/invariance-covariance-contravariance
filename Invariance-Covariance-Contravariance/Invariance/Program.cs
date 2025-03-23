namespace Invariance;

public class Program
{
    static void Main(string[] args)
    {
        // Invariance -  The type to be assigned and the type assigned must be the same. This means that there is no switch between Child (Derived) type and Parent (Base) type.
        ICar<BMW> car = new BMW();

        // Covariance Compile Error
        // ICar<Car> car1 = new BMW();

        Console.WriteLine(car.Drive());

        Console.WriteLine("Hello, World!");
    }
}
