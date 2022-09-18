namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<string> pilaHamburguesas = new Stack<string>();

            pilaHamburguesas.Push("cheeseburger");
            pilaHamburguesas.Push("Whooper");
            pilaHamburguesas.Push("King Pollo");
            pilaHamburguesas.Push("Cuarto de Libra");

            foreach (string item in pilaHamburguesas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(pilaHamburguesas.Peek());

            Console.WriteLine();

            pilaHamburguesas.Pop();

            Console.WriteLine();

            Console.WriteLine(pilaHamburguesas.Peek());

            Console.WriteLine();

            Console.WriteLine(pilaHamburguesas.Contains("Cuarto de Libra"));

        }
    }
}