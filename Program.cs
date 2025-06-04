namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona("Joan", 16);
            person1.Saluda();
            person1.Saluda("es");
            person1.Saluda("en");
        }
    }
}