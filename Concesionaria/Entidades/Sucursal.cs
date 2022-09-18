using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private Gerente gerenteSucursal;
        private int capacidadMaxima;
        private List<Auto> listadoAutos;
        string ubicacion;
        string telefono;

        private Sucursal()
        {
            listadoAutos = new List<Auto>();
        }

        public Sucursal(Gerente gerenteSucursal, int capacidadMaxima, string ubicacion)
        {
            this.gerenteSucursal = gerenteSucursal;
            this.capacidadMaxima = capacidadMaxima;
            this.ubicacion = ubicacion;
        }

        public Sucursal(Gerente gerenteSucursal, int capacidadMaxima, string ubicacion, string telefono):this(gerenteSucursal, capacidadMaxima, ubicacion)
        {
            this.telefono = telefono;
        }

        

        public bool AgregarAuto(Auto auxAuto)
        {
            if (listadoAutos.Count >= capacidadMaxima || auxAuto is null)
            {
                return false;
            }
            else
            {
                listadoAutos.Add(auxAuto);
                return true;
            }
        }
    }
}
