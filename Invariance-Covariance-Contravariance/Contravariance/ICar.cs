namespace Contravariance;

public interface ICar<in T> where T : Car
{
    string Drive();

    // Works with Contravariance
    void Drive(T car);

    // Works with Contravariance
    T DriveProp { set; }

    // Compile Error with Contravariance
    // T DriveProp { get; }
}
