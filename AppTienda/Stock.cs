using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Stock
    {
        private List<Prenda> listado = new List<Prenda>();

        public void agregarPrenda(Prenda prenda)
        {
            listado.Add(prenda);
        }

        public void quitarPrenda(Prenda prenda)
        {
            listado.Remove(prenda);
        }
    }
}
