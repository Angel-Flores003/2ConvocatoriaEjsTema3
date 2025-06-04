using EjsTema3.Ej18;

namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricBike bike = ElectricBike.CreateDefaultBike();
            bike.TransportMode();
        }
    }
}