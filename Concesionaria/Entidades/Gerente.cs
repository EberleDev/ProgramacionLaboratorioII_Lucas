namespace Entidades
{
    public class Gerente
    {
      private string nombreCompleto;
      private int antiguedad;
      private int edad;
      private float ganancia;
        
        public Gerente(string nombre, int antiguedad, int edad, float ganancia)
        {
            this.nombreCompleto = nombre;
            this.antiguedad = antiguedad;
            this.edad = edad;
            this.ganancia = ganancia;
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }

        public int Edad
        {
            get { return edad; }
        }

    }
}