using System.ComponentModel;

namespace Ejercicio01_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Random rdm = new Random();

            for (int i = 0; i < 20; i++)
            {
                int numero = rdm.Next(-10, 10);

                numeros.Add(numero);
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            Console.WriteLine("Solo positivos:");

            numeros.Sort();
            numeros.Reverse();

            foreach (int numero in numeros)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Solo negativos:");

            numeros.Reverse();

            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}