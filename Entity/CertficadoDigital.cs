using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CertficadoDigital
    {
        public string RutaCertificado { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public void CargarCertificado()
        {
            // Lógica para cargar el certificado digital
        }

        public void FirmarXML()
        {
            // Lógica para firmar el XML
        }
    }
}
