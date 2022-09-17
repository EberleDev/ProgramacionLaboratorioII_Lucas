namespace Biblioteca
{
    public static class Validadora
    {

        public static bool ValidarNumerico(string numeroIngresado, int minimo, int maximo)
        {
            if(Validadora.EsNumerico(numeroIngresado))
            {
                int numero = int.Parse(numeroIngresado);

                if(ComprobarRangoValido(numero, maximo, minimo))
                {
                    return true;
                }
            }
            return false;  
        }

        private static bool ComprobarRangoValido(int valor, int valorMaximo, int valorMinimo)
        {
            return valor < valorMaximo && valor > valorMinimo;
        }

        private static bool EsNumerico(string numero)
        {
            int retorno;

            if(int.TryParse(numero, out retorno))
            {
                return true;
            }
            return false;
        }

    }
}