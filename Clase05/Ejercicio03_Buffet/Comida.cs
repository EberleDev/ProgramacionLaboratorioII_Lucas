using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_Buffet
{
    internal class Comida
    {
        private int codigo;
        private string nombre;
        private double precio;

        public Comida(int codigo)
        {
            this.nombre = "dato no cargado";
            this.codigo = codigo;
        }

        public Comida(int codigo, string nombre, float precio) : this(codigo)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Producto: ");
            sb.Append(nombre);
            sb.Append(" - ");
            sb.Append("Precio: $");
            sb.Append(precio);

            return sb.ToString();
        }

    }
}
