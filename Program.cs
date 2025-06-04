namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = Calculadora.Sumar(3, 2);
            int resta = Calculadora.Restar(5, 2);
            int multiplicacio = Calculadora.Multiplicar(4, 3);
            double divisio = Calculadora.Dividir(10, 2);

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicació: {multiplicacio}");
            Console.WriteLine($"Divisió: {divisio}");
        }
    }
}