using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class TipoPago
    {
        public string Tipo_Pago
        {
            get; set;
        }
        public TipoPago()
        { }
        public TipoPago(string _Tipo_Pago)
        {
            Tipo_Pago = _Tipo_Pago;
        }
    }
}
