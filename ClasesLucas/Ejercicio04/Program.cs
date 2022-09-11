namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEvaluado = 2;
            int acumulador = 0;
            int[] numerosPerfectos = new int[4];
            int contador = 0;

            Console.WriteLine("Los números perfectos son: ");
            do
            {
                for (int i = 1; i < numeroEvaluado; i++)
                {
                    if((numeroEvaluado % i) == 0)
                    {
                        acumulador += i;
                    }
                }

                if (acumulador == numeroEvaluado)
                {
                    Console.WriteLine(numeroEvaluado);
                    contador++;
                }
                numeroEvaluado++;
                acumulador = 0;

             }while(contador < 4);

        }
    }
}