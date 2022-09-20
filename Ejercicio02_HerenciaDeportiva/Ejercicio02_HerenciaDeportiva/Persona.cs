using System.Text;

namespace Ejercicio02_HerenciaDeportiva
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, long dni) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(nombre);
            sb.AppendLine(dni.ToString());

            return sb.ToString();
        }
    }
}