using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema3
{
    public static class Calculadora
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Restar(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No es pot dividir per zero.");
                throw new DivideByZeroException("No es pot dividir per zero.");                
            }
            return a / b;
        }
    }
}