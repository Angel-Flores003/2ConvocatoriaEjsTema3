using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public class Persona
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("El nom no pot estar buit");
                }
                else
                {
                    nom = value;
                }
            }
        }
        private int edat;
        public int Edat
        {
            get { return edat; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("L'edat no pot ser negativa");
                }
                edat = value;
            }
        }
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
            return $"Nom: {Nom}, Edad: {Edat}";
        }
        public void Saluda()
        {
            Console.WriteLine($"Hola, soc {Nom}");
        }
        public void Saluda(string idioma)
        {
            if (!string.IsNullOrWhiteSpace(idioma))
            {
                switch (idioma.ToLower())
                {
                    case "ca":
                        Console.WriteLine($"Hola, sóc {Nom}");
                        break;
                    case "es":
                        Console.WriteLine($"Hola, soy {Nom}");
                        break;
                    case "en":
                        Console.WriteLine($"Hello, I am {Nom}");
                        break;
                    default:
                        Console.WriteLine($"Hola, soc {Nom}");
                        break;
                }
            }
            else
            {
                Saluda();
            }            
        }
    }
}