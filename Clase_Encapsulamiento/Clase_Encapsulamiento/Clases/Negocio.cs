using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Encapsulamiento.Clases
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private String nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
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

            if (n.clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en fila!");
            }
            else
            {
                List<Cliente> aux = new List<Cliente>();
                aux = n.clientes.ToList();

                if (aux.Contains(c))
                {
                    retorno = true;
                }
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

            if(n.ClientesPendientes > 0)
            {
                return (n.caja.Atender(n.Cliente));
            }
            else
            {
                Console.WriteLine("Ya no hay clientes por atender");
                return false;
            }
        }
    }
}
