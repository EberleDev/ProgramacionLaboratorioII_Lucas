namespace Ejercicio03_Buffet
{
    internal class Cliente
    {
        private string nombre;

        public Cliente(string nombreIngresado)
        {
            this.nombre = nombreIngresado;
        }

        public string Nombre
        {
            get { return nombre; }
        }
    }
}