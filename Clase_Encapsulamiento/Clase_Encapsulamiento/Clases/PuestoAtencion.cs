

namespace Clase_Encapsulamiento.Clases
{
    internal class PuestoAtencion
    {
        static private int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        {
            get { return numeroActual; }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(5000);
            return true;
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
        

    }
}