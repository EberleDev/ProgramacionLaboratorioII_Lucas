using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Futbolista : Persona
    {
        private Enumerados.Eposicion _posicion;

        public Futbolista(string nombre, Enumerados.Eposicion posicion) : base(nombre)
        {
            _posicion = posicion;
        }

        public string Posicion
        {
            get { return _posicion.ToString(); }
            
        }

        public override string Entrenar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append("Soy futbolissta y entreno!");

            return sb.ToString();

        }


    }
}
