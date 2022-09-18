
using EntidadesDeporte;

namespace TorneoFutbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Josele", 33, 8, Jugador.EPosicion.Delantero);

            j1.Nombre = null;

        }
    }
}