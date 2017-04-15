using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class TipoComprobante
    {
        public string Tipo_Comprobante
        {
            get; set;
        }
        public TipoComprobante()
        { }
        public TipoComprobante(string _Tipo_Comprobante)
        {
            Tipo_Comprobante = _Tipo_Comprobante;
        }
    }
}
