namespace Contravariance;

public class Program
{
    static void Main(string[] args)
    {
        // Contravariance -  We can switch from Parent (Base) type to Child (Derived) type.
        ICar<BMW> car = new Engine<Car>();

        Console.WriteLine(car.Drive());

        // IComparable;

        Console.WriteLine("Hello, World!");
    }
}
