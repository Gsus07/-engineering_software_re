using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public string DetalleFacturaID { get; set; }
        public int CantidadProducto { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal IVA { get; set; }
        public Producto Productos;

        public void CalcularValorTotal()
        {
            ValorTotal = CantidadProducto * Productos.ValorUnitario;
        }

        public decimal CalcularIVA()
        {
            return ValorTotal * (IVA / 100);
        }
    }
}
