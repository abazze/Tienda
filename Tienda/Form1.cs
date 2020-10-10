using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Form1 : Form
    {
        Vendedor vendedor = null;
        Tienda tienda = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vendedor = new Vendedor("Agustín", "Bazze", 1);
            tienda = new Tienda("Global Citizen", "Av. Emilio Civit 444", vendedor);

            this.lblVendedor.Text = vendedor.imprimirVendedor();
            this.lblNombreTienda.Text = tienda.Nombre;
            this.lblDireccionTienda.Text = tienda.Direccion;
        }
    }
}
