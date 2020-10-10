using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Vendedor> empleados = new List<Vendedor>();

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void agregaVendedor(Vendedor vendedor)
        {
            empleados.Add(vendedor);
        }

        public void quitaVendedor(Vendedor vendedor)
        {
            empleados.Remove(vendedor);
        }
    }
}
