using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ventas
    {
        public string NumeroFactura { get; set; }
        public string FechaFactura { get; set; }
        public string Ciudad { get; set; }
        public string Categoria { get; set; }
        public string Tienda { get; set; }
        public string Vendedor { get; set; }
        public int IdCliente { get; set; }
        public int SubTotal { get; set; }
        public int Total { get; set; }
        public bool Estado { get; set; }
        public string Modelo { get; set; }
        public string NumeroMotor { get; set; }
        public string Cilindraje { get; set; }
        public string Color { get; set; }
        public int Precio { get; set; }

    }
}

