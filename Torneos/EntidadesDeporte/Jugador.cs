using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeporte
{
    public partial class Jugador
    {
        private string nombre;
        private int edad;
        private int numeroCamiseta;
        private Enum posicion;

        public Jugador(string nombre, int edad, int numeroCamiseta, EPosicion posicion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.numeroCamiseta = numeroCamiseta;
            this.posicion = posicion;
        }

        public string Nombre
        {
            get { return nombre; }

            set { CambiarNombre(value); }
        }

        public void CambiarNombre(string nombreTentativo)
        {
            if(nombreTentativo is not null)
            {
                this.nombre = nombreTentativo;
            }
            else
            {
                Console.WriteLine("Nombre incorrecto");
            }
        }
    }




}
