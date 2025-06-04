using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public class Persona
    {
        public string Nom { get; set; }        
        public int Edat { get; set; }
        public Persona(string nom, int edat)
        {
            Nom = nom;            
            Edat = edat;
        }
        public Persona()
        {
            Nom = "Paco";
            Edat = 20;
        }
        public override string ToString()
        {
            return $"{Nom}, Edad: {Edat}";
        }
        public void Saluda()
        {
            Console.WriteLine($"Hola, soc {Nom}");
        }
    }
}