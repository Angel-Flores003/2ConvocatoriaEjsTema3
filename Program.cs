namespace EjsTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona("Joan", 30);
            Persona person2 = new Persona();
            person1.Saluda();
            person2.Saluda();
        }
    }
}