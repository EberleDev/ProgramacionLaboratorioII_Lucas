
using Ejercicio01_MaquinaExpendedora;

namespace Ejercicio2_Comida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigoIngresado;
            bool esNumerico;
            int codigo;

            Stack<Producto> stackPapasFritas = new Stack<Producto>();
            Stack<Producto> stackAlfajores = new Stack<Producto>();
            Stack<Producto> stackBarritas = new Stack<Producto>();

            int codigoPapasFritas = 1000;
            int codigoAlfajores = 2000;
            int codigoBarritas = 3000;

            for (int i = 0; i < 10; i++)
            {
                stackPapasFritas.Push(new Producto(codigoPapasFritas, "Papas Fritas", 80));
                codigoPapasFritas++;
            }

            for (int i = 0; i < 10; i++)
            {
                stackAlfajores.Push(new Producto(codigoAlfajores, "Alfajor", 100));
                codigoAlfajores++;
            }

            for (int i = 0; i < 10; i++)
            {
                stackBarritas.Push(new Producto(codigoBarritas, "Barrita Cereal", 80));
                codigoBarritas++;
            }

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            maquinaExpendedora.Add(1, stackPapasFritas);
            maquinaExpendedora.Add(2, stackAlfajores);
            maquinaExpendedora.Add(3, stackBarritas);

            Console.WriteLine();
            Console.WriteLine("¡BIENVENIDO!");
            Console.WriteLine();
            Console.WriteLine("Productos disponibles: ");
            Console.WriteLine();

            Console.WriteLine($"stack fritas: {maquinaExpendedora[1].Count}");
            Console.WriteLine($"stack alfajor: {maquinaExpendedora[2].Count}");
            Console.WriteLine($"stack barritas: {maquinaExpendedora[3].Count}");
            Console.WriteLine();


            foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
            {
                Stack < Producto > aux= item.Value;

                if (aux.Count > 0)
                {
                    Console.WriteLine($"Código: {item.Key} - {aux.Peek().Mostrar()} - Cantidad: {aux.Count}");
                }
            }

            do
            {
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("¿Qué desea comprar?");
                    Console.WriteLine("Por favor ingrese el código de producto deseado: ");

                    codigoIngresado = Console.ReadLine();
                    
                    esNumerico = int.TryParse(codigoIngresado, out codigo);

                    if (codigoIngresado == "s")
                    {
                        break;
                    }

                    if (!esNumerico || !maquinaExpendedora.ContainsKey(codigo) || maquinaExpendedora[codigo].Count == 0)
                    {
                        Console.WriteLine("Producto inválido. Reintente.");
                        Console.WriteLine("o ingrese 's' para finalizar la transacción");
                    }

                } while (!esNumerico || !maquinaExpendedora.ContainsKey(codigo));

                if (codigoIngresado != "s" && codigoIngresado is not null && maquinaExpendedora[codigo].Count > 0)
                {

                        Console.WriteLine();
                        Console.WriteLine($"{maquinaExpendedora[codigo].Pop().Mostrar()} ENTREGADO!");
                }

                Console.WriteLine();
                Console.WriteLine("Productos disponibles: ");
                Console.WriteLine();

                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    Stack<Producto> aux = item.Value;

                    if(aux.Count > 0)
                    {
                        Console.WriteLine($"Código: {item.Key} - {aux.Peek().Mostrar()} - Cantidad: {aux.Count}");
                    }
                }

            } while (codigoIngresado != "s" && maquinaExpendedora.Count > 0);

            Console.WriteLine("Compra finalizada.");
            Console.WriteLine("¡Que tenga buen día!");
        }
    }
}