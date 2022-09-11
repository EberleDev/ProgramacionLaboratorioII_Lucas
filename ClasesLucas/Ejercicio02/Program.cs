using System.Xml;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            bool resultadoParse;
            int numero;
            int cuadrado;
            int cubo;

            do
            {
                Console.WriteLine("Ingrese un número mayor a cero: ");

                dato = Console.ReadLine();
                resultadoParse = int.TryParse(dato, out numero);
                
                if (!resultadoParse || numero == 0)
                {
                    Console.WriteLine("Dato incorrecto!!!");
                }
            } while (!resultadoParse || numero == 0);

            cuadrado = numero*numero;
            cubo = cuadrado * numero;

            Console.WriteLine($"El número ingresado es {numero}, su cuadrado es {cuadrado} y el cubo es {cubo}");
        }
    }
}