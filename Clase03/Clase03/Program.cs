using Biblioteca;

namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string edadIngresada = Console.ReadLine();

            if(edadIngresada is not null)
            {
                if (Validadora.ValidarNumerico(edadIngresada, 0, 100))
                {
                    int edad = int.Parse(edadIngresada);

                    Persona persona1 = new Persona(edad);
                }
            }

            


        }
    }
}