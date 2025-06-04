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
        public string BatteryCapacity { get; set; }
        public string Autonomy { get; set; }
        public Vehicle(string brand, string batteryCapacity, string autonomy)
        {
            Brand = brand;
            BatteryCapacity = batteryCapacity;
            Autonomy = autonomy;
        }
    }
}