using EjsTema3.Ej18;

namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricBike bike = new ElectricBike("Yamaha", "500Wh", "100km");
            ElectricCar car = new ElectricCar("Tesla", "75kWh", "500km");

            bike.TransportMode();
            car.TransportMode();
        }
    }
}