namespace Contravariance;

public class Program
{
    static void Main(string[] args)
    {
        // Contravariance -  We can switch from Parent (Base) type to Child (Derived) type.
        ICar<BMW> car = new Engine<Car>();
        ICar<BMW> car1 = new Engine<BMW>();

        Console.WriteLine(car.Drive());

        // IComparable;
        // IEqualityComparer

        Console.WriteLine("Hello, World!");
    }
}
