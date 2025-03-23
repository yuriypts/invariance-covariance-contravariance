namespace Covariance;

public interface ICar<out T> where T : Car
{
    string Drive();

    // Compile Error with Convariance
    // void Drive(T car);

    // Compile Error with Convariance
    // T DriveProp { set; }

    // Works with Convariance
    T DriveProp { get; }
}
