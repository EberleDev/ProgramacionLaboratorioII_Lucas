using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Guitarra
    {
        //atributos

        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;

        //constructor

        public Guitarra(string marca, int precio)
        {
            this.marca = marca;
            this.precio = precio;
            material = "No Cargado";
        }

        public Guitarra(string marca, int precio, string material):this(marca, precio)
        {
            this.material = material;
        }

        public Guitarra(string marca, int precio, string material, bool estaAfinada,  int cantCuerdas):this(marca, precio, material)
        {
            this.estaAfinada = estaAfinada;
            cantidadCuerdas = cantCuerdas;
        }




        //comportamientos

        public bool Afinar()
        {
            bool retorno = false;

            return retorno;
        }

        public void SubirDePrecio(int aumento)
        {
            precio *= aumento;
        }

        
    }
}
