using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaElectronica
    {
        public string NumeroFactura { get; set; }
        public Emisor Emisor { get; set; }
        public Receptor Receptor { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<Producto> Items { get; set; }
        public Impuesto Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
