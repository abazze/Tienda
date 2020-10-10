using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    class Cotizacion
    {
        private int nroIdentificacion;
        private DateTime fechaYHora;
        private Vendedor vendedor;
        private string prenda;
        private int cantidadUnidades;
        private float resultadoCotizacion;

        public float Cotizar(float precio, string prenda, string tipoPrenda, string calidad)
        {
            if (prenda == "Pantalon")
            {
                if(tipoPrenda == "CH")
                {
                    precio = precio - (precio * 0.12f);
                }
            }
            else
            {
                if (tipoPrenda == "M")
                {
                    precio = precio - (precio * 0.1f);
                }
                else if(tipoPrenda == "C")
                {
                    precio = precio + (precio * 0.03f);
                }
                else
                {
                    precio = (precio - (precio * 0.1f)) + (precio * 0.03f);
                }
            }

            if (calidad == "P")
                precio = precio + (precio * 0.3f);

            return precio;
        }
    }
}
