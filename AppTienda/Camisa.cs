using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    class Camisa: Prenda
    {
        private bool cuelloMao;
        private bool mangaCorta;

        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }
        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
    }
}
