using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InformeFinanciero
    {
        
        public decimal GananciaTotal { get; set; }
        public decimal PerdidaTotal { get; set; }
        public decimal Gasto { get; set; }
        public decimal Inversion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }


    }
}
