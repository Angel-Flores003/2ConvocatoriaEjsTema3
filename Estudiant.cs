using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public class Estudiant : Persona
    {
        public string Curs { get; set; }
        public Estudiant(string nom, int edat, string curs) : base(nom, edat)
        {
            Curs = curs;
        }
        public Estudiant() : base()
        {
            Curs = "1r ESO";
        }
        public void Estudiar()
        {
            Console.WriteLine($"{Nom} està estudiant");
        }
    }
}