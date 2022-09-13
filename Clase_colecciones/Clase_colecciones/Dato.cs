using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase_colecciones
{
    public class Dato
    {
        public static void Diccionario()
        {
            Console.WriteLine("Diccionario");

            Auto autoUno = new Auto("Corsa", "Chevrolet");
            Auto autoDos = new Auto("Focus", "Ford");
            Auto autoTres = new Auto("Civic", "Honda");

            Dictionary<string, Auto> autos = new Dictionary<string, Auto>();

            autos.Add("abc123", autoUno);
            autos.Add("jhy451)", autoDos);
            autos.Add("ggt109", autoTres);

            foreach(KeyValuePair<string, Auto> auto in autos)
            {
                Console.WriteLine($"Clave: {auto.Key}, Valor: {auto.Value.MostrarInfo()}");
            }
        }

        public static void Lista()
        {
            Auto autoUno = new Auto("Corsa", "Chevrolet");
            Auto autoDos = new Auto("Focus", "Ford");
            Auto autoTres = new Auto("Civic", "Honda");

            List<Auto> autos = new List<Auto>();

            autos.Add(autoUno);
            autos.Add(autoDos);
            autos.Add(autoTres);

            foreach(Auto auto in autos)
            {
                Console.WriteLine(auto.MostrarInfo());
            }

            if(autos.Remove(autoUno))
            {
                Console.WriteLine("Se elimino el auto");
            }

            foreach (Auto auto in autos)
            {
                Console.WriteLine(auto.MostrarInfo());
            }


        }
    }
}
