using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private Vendedor vendedor;
        private List<Prenda> prendas;



        public Tienda(string nom, string dir, Vendedor v)
        {
            this.Nombre = nom;
            this.Direccion = dir;
            this.vendedor = v;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
