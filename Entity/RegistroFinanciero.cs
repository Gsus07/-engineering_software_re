using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class RegistroFinanciero
    {
        public string RegistroID { get; set; }
        public decimal GananciaTotal { get; set; }
        public decimal PerdidaTotal { get; set; }
        public decimal Gastos { get; set; }
        public decimal Inversion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
