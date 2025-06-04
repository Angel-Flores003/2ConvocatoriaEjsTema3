using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3.Ej18
{
    public class ElectricBike : Vehicle, ITransportable
    {
        public ElectricBike(string brand, double batteryCapacity, double autonomy) : base(brand, batteryCapacity, autonomy) { }

        public void TransportMode()
        {
            Console.WriteLine($"El vehicle es transoprta amb 'ElectricBike'\n Brand: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}");
        }
        public override string ToString()
        {
            return $"ElectricBike: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}";
        }
    }
}