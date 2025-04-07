namespace Invariance_Covariance_Contravariance;

public abstract class Reset
{
    public abstract void ResetData();
}

public class Forward : Reset
{
    public override void ResetData()
    {
        Console.WriteLine("Forward");
    }
}

public class Volatility : Reset
{
    public override void ResetData()
    {
        Console.WriteLine("Volatility");
    }
}

public class Base { };
public class Derived : Base
{
    public static explicit operator Derived(Base b)
    {
        return new Derived();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Invariance     -  The type to be assigned and the type assigned must be the same. This means that there is no switch between Child (Derived) type and Parent (Base) type.
        // Covariance     -  We can switch from Child (Derived) type to Parent (Base) type.
        // Contravariance -  We can switch from Parent (Base) type to Child (Derived) type.

        var test = new string("asd");
        object test1 = new string("asd");

        //Derived derived = (Derived)"asd";

        List<Reset> objToReset = new List<Reset>
        {
            new Forward(),
            new Volatility(),
        };

        foreach (var item in objToReset)
        {
            item.ResetData();
        }

        Console.WriteLine("Hello, World!");
    }

    // Assignment Compatibility
    public object GetObject()
    {
        string value1 = "value1";
        object value2 = "value2"; 
                                  
        //string value3 = value2; // Compiler Error

        return value1;
    }

    // Conversion for Arrays and Collections
    public object[] GetArray()
    {
        object[] array = new string[3];
        array[0] = "";
        array[1] = true; // RunTime Error

        //List<object> list = new List<string>(); // Compiler Error

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
    IExample<object> example5 = (IExample<object>)null; // Compiler Error
}
