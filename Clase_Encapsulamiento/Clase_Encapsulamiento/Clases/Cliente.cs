using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Encapsulamiento.Clases
{
    internal class Cliente
    {

        private string _nombre;
        private int _numero;

        public Cliente(int numero)
        {
            _numero = numero;
        }
        public Cliente(int numero, string nombre) :this(numero)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Numero
        {
            get { return _numero; }
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            bool retorno = false;

            if(c1.Numero == c2.Numero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }

    }
}
