namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] persones = new Persona[3];
            string nom;
            int edat;
            for (int i = 0; i < persones.Length; i++)
            {
                Console.WriteLine($"Introdueix el nom de la persona {i + 1}:");
                nom = Console.ReadLine();
                Console.WriteLine($"Introdueix l'edat de la persona {i + 1}:");                
                while (!int.TryParse(Console.ReadLine(), out edat) || edat < 0)
                {
                    Console.WriteLine("Edat no vàlida. Introdueix una edat positiva:");
                }
                persones[i] = new Persona(nom, edat);
                Console.WriteLine("\n");
            }
            for (int i = 0; i < persones.Length; i++)
            {
                //Console.WriteLine($"Persona {i + 1}: {persones[i]}");
                persones[i].Saluda();
            }
        }
    }
}