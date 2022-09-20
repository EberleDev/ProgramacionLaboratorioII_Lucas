using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_HerenciaDeportiva
{
    internal class Jugador : Persona
    {
        int partidosJugados;
        int totalGoles;

        public Jugador(string nombre, long dni):base(nombre, dni)
        {

        }
        public Jugador(string nombre, long dni, int partidosJugados, int totalGoles):base(nombre, dni)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }



    }
}
