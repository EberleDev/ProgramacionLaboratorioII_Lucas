namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string datoIngresado;
            bool resultadoParseo;
            int numeroIngresado;

            int numeroPrueba = 2;
            int acumuladorMenor = 0;
            int acumuladorMayor = 0;

            do
            {
                Console.WriteLine("Por favor ingrese un número: ");

                datoIngresado = Console.ReadLine();

                resultadoParseo = int.TryParse(datoIngresado, out numeroIngresado);

                if (!resultadoParseo)
                {
                    Console.WriteLine("Dato incorrecto.");
                }
            } while (!resultadoParseo);

            do
            {
                int numeroResta = numeroPrueba;
                do
                {
                    numeroResta--;
                    acumuladorMenor += numeroResta;

                } while (numeroResta > 1);

                //Console.WriteLine($"Acumulador menor: {acumuladorMenor}");

                int numeroSuma = numeroPrueba;

                do
                {
                    numeroSuma++;
                    acumuladorMayor += numeroSuma;

                } while (acumuladorMayor < acumuladorMenor);

                //Console.WriteLine($"Acumulador Mayor: {acumuladorMayor}");

                if(acumuladorMayor == acumuladorMenor)
                {
                    Console.WriteLine();
                    Console.WriteLine("Alcoyana, Alcoyana!");
                    Console.WriteLine("CENTRICO ES: " + numeroPrueba);
                    Console.WriteLine($"Su minimo es {acumuladorMenor} y su maximo es {acumuladorMayor}");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                numeroPrueba++;
                acumuladorMayor = 0;
                acumuladorMenor = 0;

            }while(numeroPrueba < numeroIngresado);
        }
    }
}