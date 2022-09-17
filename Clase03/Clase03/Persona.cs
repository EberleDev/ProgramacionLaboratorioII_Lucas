namespace Clase03
{
    internal class Persona
    {
        //atributos

        private string dni;
        private int edad;


        //constructores
        public Persona(string dni)
        {
            this.edad = -1;
            this.dni = dni;
        }
        public Persona(int edad)
        {
            this.dni = "Dato no ingresado";
            this.edad = edad;
        }

        //properties

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
    }
}