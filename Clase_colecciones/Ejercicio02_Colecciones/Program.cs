namespace Ejercicio02_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            List<int> auxList = new List<int>();

            Random rdm = new Random();

            for (int i = 0; i < 20; i++)
            {
                int numero = rdm.Next(-10, 10);

                numeros.Enqueue(numero);
            }

            foreach (int item in numeros)
            {
                auxList.Add(item);
            }

            auxList.Sort();

            foreach (int itemAux in auxList)
            {
                if(itemAux > 0)
                {
                    Console.WriteLine(itemAux);
                }
            }

            auxList.Reverse();

            foreach (int itemAux in auxList)
            {
                if(itemAux < 0)
                {
                    Console.WriteLine(itemAux);
                }

            }
        }       
    }
}