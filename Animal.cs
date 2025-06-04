using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public abstract class Animal
    {
        public string Nom { get; }
        public Animal(string nom)
        {
            Nom = nom;
        }
        public abstract void So();
    }
}