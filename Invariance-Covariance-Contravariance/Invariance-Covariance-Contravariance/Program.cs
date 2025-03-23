namespace Invariance_Covariance_Contravariance;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    // Assignment Compatibility
    public object GetObject()
    {
        string value1 = "value1";
        object value2 = "value2"; 
                                  
        string value3 = value2; // Compiler Error

        return value1;
    }

    // Conversion for Arrays and Collections
    public object[] GetArray()
    {
        object[] array = new string[3];
        array[0] = "";
        array[1] = 5; // RunTime Error

        return array;
    }

    // Conversion for Generic Interfaces
    interface IExample<T> { }

    //Invariance approach
    IExample<int> example = (IExample<int>)null;

    IExample<string> example2 = (IExample<string>)null; 

    //Covariance approach
    IExample<object> example3 = (IExample<string>)null; // Compiler Error

    //Contravariance approach
    IExample<string> example4 = (IExample<object>)null; // Compiler Error
}
