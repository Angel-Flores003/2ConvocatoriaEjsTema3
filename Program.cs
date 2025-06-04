using EjsTema3.Ej18;
using System.Runtime.CompilerServices;

namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcio;

            do
            {
                Console.WriteLine("\n MENÚ DE VEHICLES ELÈCTRICS");
                Console.WriteLine("1. Afegir vehicle");
                Console.WriteLine("2. Llistar vehicles");
                Console.WriteLine("3. Sortir");
                Console.Write("Escull una opció: ");

                if (!int.TryParse(Console.ReadLine(), out opcio)) opcio = 0;

                switch (opcio)
                {
                    case 1:
                        AfegirVehicle();
                        break;
                    case 2:
                        LlistarVehicles();
                        break;
                    case 3:
                        Console.WriteLine("Dew");
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida.");
                        break;
                }

            } while (opcio != 3);
        }

        static void AfegirVehicle()
        {
            string type, brand;
            double bateria, autonomia;

            Console.Write("Tipus de vehicle (cotxe/bici): ");
            type = Console.ReadLine().ToLower();

            Console.Write("Marca: ");
            brand = Console.ReadLine();

            Console.Write("Bateria (kWh): ");
            bateria = Convert.ToDouble(Console.ReadLine());

            Console.Write("Autonomia (km): ");
            autonomia = Convert.ToDouble(Console.ReadLine());

            if (type == "cotxe")
            {
                ElectricCar car = new ElectricCar(brand, bateria, autonomia);
                Console.WriteLine($"Cotxe afegit: {car}");
            }
            else if (type == "bici")
            {
                ElectricBike bike = new ElectricBike(brand, bateria, autonomia);
                Console.WriteLine($"Bicicleta afegida: {bike}");
            }
            else
            {
                Console.WriteLine("Tipus de vehicle no vàlid.");
            }
        }

        static void LlistarVehicles()
        {
            for (int i = 0; i < 2; i++)
            {
                ElectricBike bike = ElectricBike.CreateDefaultBike();
                Console.WriteLine(bike);
            }
        }
    }
}