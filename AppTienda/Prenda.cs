using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    abstract class Prenda
    {
        public enum tipoCalidad { standard, premium };
        private tipoCalidad calidad;
        private float precio;
        private int cantidad;

        internal tipoCalidad Calidad { get => calidad; set => calidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public float precioCalculado() {
            return precio;
        }
    }
}
