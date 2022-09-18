using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_MaquinaExpendedora
{
    public class Producto
    {
        private int codigoProducto;
        private string nombre;
        private float precio;

        public Producto(int codigoProducto, string nombre, float precio)
        {
            this.codigoProducto = codigoProducto;
            this.nombre = nombre;
            this.precio = precio;
        }


        public int Codigo
        {
            get { return codigoProducto; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public float Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Producto: {this.Nombre} - Precio: ${this.Precio}");
            return sb.ToString();
        }
    }

}
