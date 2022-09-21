namespace Entidades
{
    public abstract class Persona
    {
        private string _nombre;

        public Persona(string nombre)
        {
            this._nombre = nombre;
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public abstract string Entrenar();

        public override string? ToString()
        {
            return base.ToString();
        }

    }
}