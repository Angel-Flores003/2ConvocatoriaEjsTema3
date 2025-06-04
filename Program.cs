using EjsTema3.Ej18;

namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type, brand;
            double batteryCapacity, autonomy;
            Vehicle vehicle;

            Console.WriteLine("Introdueïx el tipus de vehicle (cotxe/bici)");
            type = Console.ReadLine().ToLower();

            Console.WriteLine("Introdueïx la marca del vehicle");
            brand = Console.ReadLine();

            Console.WriteLine("Introdueïx la capacitat de la bateria (en kWh)");
            while (!double.TryParse(Console.ReadLine(), out batteryCapacity) || batteryCapacity <= 0)
            {
                Console.WriteLine("Capacitat de bateria no vàlida. Introdueix un valor positiu.");
            }

            Console.WriteLine("Introdueïx l'autonomia del vehicle (en km)");
            while (!double.TryParse(Console.ReadLine(), out autonomy) || autonomy <= 0)
            {
                Console.WriteLine("Autonomia no vàlida. Introdueix un valor positiu.");
            }
            //dividim la lògica de creació de vehicles en funció del tipus
            if (type == "cotxe")
            {
                vehicle = new ElectricCar(brand, batteryCapacity.ToString(), autonomy.ToString());                
            }
            else if (type == "bici")
            {
                vehicle = new ElectricBike(brand, batteryCapacity.ToString(), autonomy.ToString());
            }
            else
            {
                Console.WriteLine("Tipus de vehicle no vàlid. S'està creant un vehicle genèric.");
                vehicle = new Vehicle(brand, batteryCapacity.ToString(), autonomy.ToString());
            }
        }
    }
}