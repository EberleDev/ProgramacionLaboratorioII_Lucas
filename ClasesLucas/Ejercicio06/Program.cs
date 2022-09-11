namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anio = 2021;
            bool bisiesto = false;

            Console.Write($"El anio {anio} es: ");
            if(anio % 4 ==0 && anio % 100 != 0 || anio % 400 == 0)
            {
                bisiesto = true;
            }

            if(bisiesto)
            {
                Console.WriteLine("BISIESTO");
            }
            else
            {
                Console.WriteLine("CAQUITA");
            }
        }
    }
}