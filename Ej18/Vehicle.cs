using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3.Ej18
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public double BatteryCapacity { get; set; }
        public double Autonomy { get; set; }
        public Vehicle(string brand, double batteryCapacity, double autonomy)
        {
            Brand = brand;
            BatteryCapacity = batteryCapacity;
            Autonomy = autonomy;
        }
        public override string ToString()
        {
            return $"Vehicle: {Brand}, Battery Capacity: {BatteryCapacity}, Autonomy: {Autonomy}";
        }
    }
}