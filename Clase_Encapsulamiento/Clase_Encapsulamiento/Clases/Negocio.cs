using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Encapsulamiento.Clases
{
    internal class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private String nombre;

        public Negocio()
        {
            PuestoAtencion caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            Queue<Cliente> clientes = new Queue<Cliente>();
            nombre = "Nombre no ingresado";
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }

            set { clientes.Enqueue(value); }
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            List<Cliente> aux = new List<Cliente>();
            aux = n.clientes.ToList();

            if (aux.Contains(c))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            else
            {
                Console.WriteLine("El Cliente ya existe");
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            Cliente clientePorAtender = n.Cliente;
            
            if(n.caja.Atender(clientePorAtender))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
