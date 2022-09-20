using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        string nombre;
        int edad;
        string genero;
        string direccion;
        string pais;
        string[] cursos;

        public Ingresante ()
        {

        }
        public Ingresante(string nombre, int edad, string genero, string direccion, string pais, string[] cursos)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.direccion = direccion;
            this.pais = pais;
            cursos = new string[100];


        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }   
        }

        public string Genero
        {
            set { genero = value; }
            get
            { return genero; }   
        }

        public string Pais
        {
            set { pais = value; }
            get
            { return pais; }   
        }

        public String[] Cursos
        {
            set { cursos = value; }
            get { return cursos; }   
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+ nombre);
            sb.AppendLine("Edad: "+ edad.ToString());
            sb.AppendLine("Género: "+ genero);
            sb.AppendLine("Dirección: "+ direccion);
            sb.AppendLine("País: "+ pais);
            sb.AppendLine("Cursos: ");
            for (int i = 0; i < cursos.Length; i++)
            {
                sb.AppendLine(cursos[i]);
            }

            return sb.ToString();
        }
    }
}