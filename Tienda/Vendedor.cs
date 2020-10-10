using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigo;

        public Vendedor(string nom, string ape, int cod)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.codigo = cod;
        }

        public string imprimirVendedor()
        {
            return string.Format(this.nombre+' '+this.apellido+'|'+this.codigo);
        }
    }
}
