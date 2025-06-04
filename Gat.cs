using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public class Gat : Animal
    {
        public Gat(string nom) : base(nom) { }

        public override void So()
        {
            Console.WriteLine("Gat: Miau!");
        }      
    }    
}