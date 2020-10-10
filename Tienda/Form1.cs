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

        Prenda camisaMLCMao = null;
        Prenda camisaMLCNormal = null;
        Prenda camisaMCCMao = null;
        Prenda camisaMCCNormal = null;

        Prenda pantalonChupin = null;
        Prenda pantalonNormal = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chkChupin.Enabled = false;

            vendedor = new Vendedor("Agustín", "Bazze", 1);
            tienda = new Tienda("Global Citizen", "Av. Emilio Civit 444", vendedor);

            camisaMCCMao = new Prenda(200, "Camisa manga corta cuello mao", "MC");
            camisaMCCNormal = new Prenda(300, "Camisa manga corta normal", "M");
            camisaMLCMao = new Prenda(150, "Camisa manga larga cuello mao", "C");
            camisaMLCNormal = new Prenda(350, "Camisa manga larga cuello normal", "");

            pantalonChupin = new Prenda(1500, "Pantalón chupín", "CH");
            pantalonNormal = new Prenda(500, "Pantalón normal", "");

            this.lblVendedor.Text = vendedor.imprimirVendedor();
            this.lblNombreTienda.Text = tienda.Nombre;
            this.lblDireccionTienda.Text = tienda.Direccion;
        }

        private string ObtenerPrenda()
        {
            string resultado = string.Empty;

            if (rdbPantalon.Checked)
                resultado = "Pantalon";
            else
                resultado = "Camisa";

            return resultado;
        }

        private string ObtenerTipoPrenda()
        {
            string resultado = string.Empty;

            if (rdbCamisa.Checked)
            {
                if (chkManga.Checked)
                    resultado += "M";
                if (chkCuello.Checked)
                    resultado += "C";
            }
            else
            {
                if (chkChupin.Checked)
                    resultado += "CH";
            }

            return resultado;
        }  
        
        private string ObtenerCalidad()
        {
            string resultado = string.Empty;

            if (rdbPremium.Checked)
                resultado = "P";

            return resultado;
        }

        private float Cotizar()
        {
            float resultado = 0.0f;

            string prenda = this.ObtenerPrenda();
            string tipoPrenda = this.ObtenerTipoPrenda();
            string calidad = this.ObtenerCalidad();

            Cotizacion cotizacion = new Cotizacion();
            resultado = cotizacion.Cotizar(Convert.ToSingle(this.txtPrecio.Text), prenda, tipoPrenda, calidad);

            return resultado;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            float precioFinal = 0.0f;

            precioFinal = this.Cotizar();
            this.lblPrecioFinal.Text = "$" + precioFinal.ToString();
        }

        private void rdbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            this.chkChupin.Enabled = false;
            this.chkCuello.Enabled = true;
            this.chkManga.Enabled = true;
        }

        private void rdbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            this.chkChupin.Enabled = true;
            this.chkCuello.Enabled = false;
            this.chkManga.Enabled = false;
        }
    }
}
