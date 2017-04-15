using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Venta
    {
        public Administrativo Administrativo;
        public Cliente Cliente;
        public Servicio Servicio;
        public TipoPago TipoPago;
        public TipoComprobante TipoComprobante;
        public Venta(Administrativo _Administrativo)
        {
            Administrativo = _Administrativo;
        }
        public Venta(Cliente _Cliente)
        {
            Cliente = _Cliente;
        }
        public Venta(Servicio _Servicio)
        {
            Servicio = _Servicio;
        }
        public Venta(TipoPago _TipoPago)
        {
            TipoPago = _TipoPago;
        }
        public Venta(TipoComprobante _TipoComprobante)
        {
            TipoComprobante = _TipoComprobante;
        }
    }
}
