using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public class Veterinari : ICuidador
    {
        public Veterinari() { }
        public void Alimentar()
        {
            Console.WriteLine("El veterinari alimenta als animals.");
        }
    }
}