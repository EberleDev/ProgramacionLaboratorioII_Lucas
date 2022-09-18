using System.Collections;

namespace Ejercicio03_Buffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoIngresado;
            bool esNumerico;
            int numero;
            int indice = 0;
            string terminarPedido = "n";
            string Pedido;



            List<List<Comida>> mesaBuffet = new List<List<Comida>>();

            Queue<Cliente> filaClientes = new Queue<Cliente>();

            List<Comida> albondigas = new List<Comida>();
            List<Comida> milanesas = new List<Comida>();
            List<Comida> canelones = new List<Comida>();
            List<Comida> ravioles = new List<Comida>();
            List<Comida> matambre = new List<Comida>();

            int codigoAlbondigas = 1000;
            int codigoMilanesas = 2000;
            int codigoCanelones = 3000;
            int codigoRavioles = 4000;
            int codigoMatambre = 5000;

            for (int i = 0; i < 10; i++)
            {
                albondigas.Add(new Comida(codigoAlbondigas, "Albóndigas con Puré", 450));
                milanesas.Add(new Comida(codigoMilanesas, "Milanesas de Fritas", 450));
                canelones.Add(new Comida(codigoCanelones, "Canelones Mixtos", 400));
                ravioles.Add(new Comida(codigoRavioles, "Ravioles con Salsa Filetto", 400));
                matambre.Add(new Comida(codigoMatambre, "Matambre a la Pizza", 550));

                codigoAlbondigas++;
                codigoCanelones++;
                codigoMatambre++;
                codigoRavioles++;
                codigoMilanesas++;
            }

            mesaBuffet.Add(albondigas);
            mesaBuffet.Add(canelones);
            mesaBuffet.Add(milanesas);
            mesaBuffet.Add(ravioles);
            mesaBuffet.Add(matambre);

            do
            {
                Console.WriteLine();
                Console.WriteLine("¿Cuántos clientes quiere agregar a la cola?");

                datoIngresado = Console.ReadLine();
                esNumerico = int.TryParse(datoIngresado, out numero);

            } while (!esNumerico || numero < 1);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese el nombre del cliente N° {i + 1}: ");
                datoIngresado = Console.ReadLine();

                filaClientes.Enqueue(new Cliente(datoIngresado));
            }

            while (filaClientes.Count > 0)
            {
                Cliente clienteAtendido = filaClientes.Dequeue();
                do
                {

                    Console.WriteLine();
                    Console.WriteLine($"Bienvenido {clienteAtendido}");

                    do
                    {
                        foreach (List<Comida> item in mesaBuffet)
                        {
                            indice = 0;

                            if (item.Count > 0)
                            {
                                for (int i = 0; i < item.Count; i++)
                                {
                                    if (item[i] is not null)
                                    {
                                        indice = i;
                                        break;
                                    }
                                }
                                Console.WriteLine($"{mesaBuffet.IndexOf(item)} - {item[indice].Mostrar()} - Cantidad: {item.Count}");
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine("Ingresá el codigo de comida que queres ordenar: ");
                        datoIngresado = Console.ReadLine();
                        esNumerico = int.TryParse(datoIngresado, out numero);

                        if (!esNumerico || mesaBuffet[numero] is null)
                        {
                            Console.WriteLine("Codigo incorrecto. Reintente.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Comida orden = mesaBuffet[numero][indice];
                            bool exitoOrden = mesaBuffet[numero].Remove(mesaBuffet[numero][indice]);
                            Console.WriteLine($"Pedido: ");
                            Console.WriteLine($"-{orden}");

                        }

                    } while (!esNumerico);



                } while (terminarPedido != "s" && terminarPedido != "S");

            }














        }
    }
}