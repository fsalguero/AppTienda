using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigo;

        public Vendedor(string nombre, string apellido, int codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
