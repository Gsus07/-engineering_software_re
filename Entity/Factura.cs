using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string FacturaID { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalIVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalDescuento { get; set; }

        public Cliente cliente;
        public List<DetalleFactura> DetalleFacturas;

        public Factura()
        {
            DetalleFacturas = new List<DetalleFactura>();
        }
        public void AgregarDetalleFactura(string iddetalle, Producto producto, int cantidad, decimal Iva)
        {
            DetalleFactura detalleFactura = new DetalleFactura();
            detalleFactura.DetalleFacturaID = iddetalle;
            detalleFactura.Productos = producto;
            detalleFactura.CantidadProducto = cantidad;
            detalleFactura.CalcularValorTotal();
            detalleFactura.IVA = Iva;
            DetalleFacturas.Add(detalleFactura);
        }

        public void CalcularSubtotal()
        {
            SubTotal = DetalleFacturas.Sum(d => d.ValorTotal);
        }

        public void CalcularDescuento()
        {
            TotalDescuento = SubTotal * Descuento;
        }

        public void CalcularTotalIVA()
        {
            TotalIVA = DetalleFacturas.Sum(d => d.CalcularIVA());
        }

        public void CalcularTotal()
        {
            CalcularSubtotal();
            CalcularTotalIVA();
            CalcularDescuento();
            ValorTotal = SubTotal + TotalIVA - TotalDescuento;
        }




    }
}
