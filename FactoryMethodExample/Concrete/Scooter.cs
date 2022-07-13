using FactoryMethodExample.Abstract;

namespace FactoryMethodExample.Concrete;

public class Scooter : IFactory
{
    public void Drive(int miles)
    {
        Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
    }
}
