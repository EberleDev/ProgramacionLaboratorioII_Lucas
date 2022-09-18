namespace Ejercicio01_MaquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //    string codigoIngresado;
        //    bool esNumerico;
        //    int codigo;

        //    Producto[] arrayDeProductos = new Producto[10];

        //    Producto capitan = new Producto("Capitan Del Espacio", 80);
        //    Producto tortita = new Producto("Tortita Aguila", 100);
        //    Producto bonobom = new Producto("Bonobom", 45);
        //    Producto chupetin = new Producto("Pico Dulce", 50);
        //    Producto tita = new Producto("Tita", 50);
        //    Producto rodhesia = new Producto("Rodhesia", 70);
        //    Producto block = new Producto("Block", 125);
        //    Producto cadbury = new Producto("Cadbury Yoghurt", 150);
        //    Producto torpedo = new Producto("Torpedo", 200);
        //    Producto conogol = new Producto("Conogol", 350);

        //    arrayDeProductos[0] = capitan;
        //    arrayDeProductos[1] = tortita;
        //    arrayDeProductos[2] = bonobom;
        //    arrayDeProductos[3] = chupetin;
        //    arrayDeProductos[4] = tita;
        //    arrayDeProductos[5] = rodhesia;
        //    arrayDeProductos[6] = block;
        //    arrayDeProductos[7] = cadbury;
        //    arrayDeProductos[8] = torpedo;
        //    arrayDeProductos[9] = conogol;

        //    Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

        //    int i = 1000;

        //    foreach (Producto item in arrayDeProductos)
        //    {
        //        maquinaExpendedora.Add(i, item);
        //        i++;
        //    }

            
        //    Console.WriteLine();
        //    Console.WriteLine("¡BIENVENIDO!");
        //    Console.WriteLine();
        //    Console.WriteLine("Productos disponibles: ");
        //    Console.WriteLine();

        //    foreach(KeyValuePair<int, Producto> item in maquinaExpendedora)
        //    {
        //        Console.WriteLine($"Código: {item.Key} - {item.Value.Mostrar()}");
        //    }

        //    do
        //    {

        //        do
        //        {

        //            Console.WriteLine();
        //            Console.WriteLine("¿Qué desea comprar?");
        //            Console.WriteLine("Por favor ingrese el código de producto deseado: ");


        //            codigoIngresado = Console.ReadLine();
        //            esNumerico = int.TryParse(codigoIngresado, out codigo);

        //            if (codigoIngresado == "s")
        //            {
        //                break;
        //            }

        //            if (!esNumerico || !maquinaExpendedora.ContainsKey(codigo))
        //            {
        //                Console.WriteLine("Producto inválido. Reintente.");
        //                Console.WriteLine("o ingrese 's' para finalizar la transacción");
        //            }

        //        } while (!esNumerico || !maquinaExpendedora.ContainsKey(codigo));

        //        if (codigoIngresado != "s")
        //        {
        //            Producto productoElegido;

        //            bool entrega = maquinaExpendedora.Remove(codigo, out productoElegido);

        //            if (entrega)
        //            {
        //                Console.WriteLine();
        //                Console.WriteLine($"{productoElegido.Nombre} ENTREGADO!");
        //            }                    
        //            Console.WriteLine();
        //        }

        //        Console.WriteLine();
        //        Console.WriteLine("Productos disponibles: ");
        //        Console.WriteLine();
        //        foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
        //        {
        //            Console.WriteLine($"Código: {item.Key} - {item.Value.Mostrar()}");
        //        }

        //    } while (codigoIngresado != "s" && maquinaExpendedora.Count > 0);

        //    Console.WriteLine("Compra finalizada.");
        //    Console.WriteLine("¡Que tenga buen día!");

        }
    }
}