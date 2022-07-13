using FactoryMethodExample.Abstract;
using FactoryMethodExample.Concrete;
namespace Factory;

class Program
{
    static void Main(string[] args)
    {
        VehicleFactory factory = new ConcreteVehicleFactory();

        IFactory scooter = factory.GetVehicle("Scooter");
        scooter.Drive(40);

        IFactory bike = factory.GetVehicle("Bike");
        bike.Drive(25);


    }
}