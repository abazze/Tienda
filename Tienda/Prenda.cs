using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    class Prenda
    {
        private string calidad;
        private float precio;
        private int cantidadStock;
        private string tipoPrenda;
        private string prenda;

        public Prenda(int cant, string prenda, string tipoPrenda)
        {
            this.cantidadStock = cant;
            this.prenda = prenda;
            this.tipoPrenda = tipoPrenda;
        }
    }
}
