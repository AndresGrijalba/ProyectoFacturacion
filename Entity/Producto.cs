using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public Impuesto Impuesto { get; set; }

        public decimal CalcularValorTotal()
        {
            // Lógica para calcular el valor total del ítem
            return 0;
        }

        public void AsignarImpuesto(Impuesto impuesto)
        {
            // Asignación del impuesto al ítem
        }
    }
}
