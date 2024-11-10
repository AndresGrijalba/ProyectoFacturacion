using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Impuesto
    {
        public string TipoImpuesto { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Valor { get; set; }

        public decimal CalcularImpuesto()
        {
            // Lógica para calcular el valor del impuesto
            return 0;
        }
    }
}
