using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
