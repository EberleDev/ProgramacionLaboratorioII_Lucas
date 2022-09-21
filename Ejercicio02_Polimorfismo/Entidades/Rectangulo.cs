using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        double ladoBase;
        double ladoAltura;

        public Rectangulo(double ladoBase, double ladoAltura)
        {
            this.ladoBase = ladoBase;
            this.ladoAltura = ladoAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return ladoBase * ladoAltura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * ladoBase + 2 * ladoAltura;
        }
    }
}
