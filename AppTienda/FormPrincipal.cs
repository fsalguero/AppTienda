using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTienda
{
    public partial class FormPrincipal : Form
    {
        private Vendedor vendedor;
        private Tienda tienda;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargaDatosInciales();

            
        }


        private void cargaDatosInciales()
        {
            this.vendedor = new Vendedor("Francisco", "Salguero", 1);
            this.tienda = new Tienda("Nueva", "Ciudad Mendoza");
        }
    }
}
