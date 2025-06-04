using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3.Ej18
{
    public class ElectricCar : Vehicle
    {        
        public ElectricCar(string brand, string batteryCapacity, string autonomy) : base(brand, batteryCapacity, autonomy) { }
        public void TransportMode()
        {
            Console.WriteLine($"El vehicle es transoprta amb 'ElectricCar'\n Brand: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}");
        }
    }
}