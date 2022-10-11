using System.Runtime.Serialization;

namespace Calculador
{
    [Serializable]
    internal class ParametrosVacioException : Exception
    {
        public ParametrosVacioException(string mensaje):base(mensaje)
        {

        }

    }
}