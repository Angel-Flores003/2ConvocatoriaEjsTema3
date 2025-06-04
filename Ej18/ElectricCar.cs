using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3.Ej18
{
    public class ElectricCar : Vehicle, ITransportable
    {
        public ElectricCar(string brand, double batteryCapacity, double autonomy) : base(brand, batteryCapacity, autonomy) { }
        public void TransportMode()
        {
            Console.WriteLine($"El vehicle es transoprta amb 'ElectricCar'\n Brand: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}");
        }
        public override string ToString()
        {
            return $"ElectricCar: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}";
        }
    }
}