using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Cotizacion
    {
        private int id;
        private DateTime fechaHora;
        private Vendedor vendedor;
        private int cantidad;
        private Prenda prenda;
        private float total;

        public Cotizacion(Vendedor vendedor, Prenda prenda, int cantidad)
        {
            this.vendedor = vendedor;
            this.prenda = prenda;
            this.cantidad = cantidad;

            this.total = this.calculaTotal();
        }

        private float calculaTotal()
        {
            if (cantidad > prenda.Cantidad)
            {
                throw new Exception("No hay stock del producto");
            }

            return prenda.Precio * cantidad;
        }
    }
}
