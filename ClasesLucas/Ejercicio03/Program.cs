namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoIngresado;
            bool resultadoParseo;
            int numeroIngresado;
            string continuar = "s";
            int cantidad = 10;
            int[] numerosPrimos = new int[cantidad];
            bool esPrimo = false;
            int contador = 0;

            do
            {
                esPrimo = true;

                do
                {
                    Console.WriteLine("Por favor ingrese un número: ");

                    datoIngresado = Console.ReadLine();

                    if(datoIngresado == "salir")
                    {
                        Environment.Exit(0);
                    }

                    resultadoParseo = int.TryParse(datoIngresado, out numeroIngresado);

                    if (!resultadoParseo)
                    {
                        Console.WriteLine("Dato incorrecto.");
                        Console.WriteLine("Si desea terminar ingrese la palabra 'salir'");

                    }
                } while (!resultadoParseo);

                for (int i = 2; i < numeroIngresado; i++)
                {
                    if((numeroIngresado % i) == 0 || numeroIngresado <= 1)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if(esPrimo)
                {
                    if(contador == cantidad)
                    {
                        Array.Resize(ref numerosPrimos, cantidad * 2);
                    }

                    numerosPrimos[contador] = numeroIngresado;
                    contador++;
                }

                Console.WriteLine("Los números primos ingresados son: ");

                for (int i = 0; i < numerosPrimos.Length; i++)
                {
                    if (numerosPrimos[i] > 1)
                    {
                        Console.WriteLine(numerosPrimos[i]);
                    }
                }

                Console.WriteLine("¿Desea continuar ingresando números?");
                Console.WriteLine("Ingrese 's' para continuar: ");

                continuar = Console.ReadLine();

            } while (continuar == "s");
        }
    }
}