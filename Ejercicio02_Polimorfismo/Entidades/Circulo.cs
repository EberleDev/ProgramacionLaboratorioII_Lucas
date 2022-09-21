using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Circulo : Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo...";
        }

        public override double CalcularSuperficie()
        {
            return 3.14 * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * 3.14 * radio;
        }
    }
}
