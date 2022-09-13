using System.Text;

namespace Clase_colecciones
{
    public class Auto
    {
        public string marca;
        public string modelo;

        public Auto(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(marca);
            sb.Append(",");
            sb.Append(modelo);

            return sb.ToString();

            //Console.WriteLine($"{marca}, {modelo}");
        }
    }
}