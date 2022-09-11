namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            string datoIngresado;
            bool resultadoParse;
            int contador = 0;
            int acumulador = 0;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float promedio;

            Console.WriteLine("Ingrese 5 numeros: ");

            do
            {
                datoIngresado = Console.ReadLine();
                resultadoParse = int.TryParse(datoIngresado, out numero);

                if (resultadoParse)
                {
                    contador++;

                    acumulador += numero;

                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                }
                else
                {
                    Console.WriteLine("Dato incorrecto. Ingrese un número!");
                }

            } while (contador < 5);

            promedio = acumulador / contador;

            Console.WriteLine($"El número mínimo es {minimo}, el número máximo es {maximo} y el promedio es {promedio}");

        }
    }
}