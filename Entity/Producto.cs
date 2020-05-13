using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadBodega { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal IVAProducto { get; set; }
        public decimal Descuento { get; set; }

    }
}
