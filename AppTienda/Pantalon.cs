using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Pantalon : Prenda
    {
        private bool chupin;

        public bool Chupin { get => chupin; set => chupin = value; }
    }
}
