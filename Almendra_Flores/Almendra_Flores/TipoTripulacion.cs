using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class TipoTripulacion
    {

        private string tipoTripulacion;
        public TipoTripulacion(string _tipoTripulacion)
        {
            tipoTripulacion = _tipoTripulacion;
        }
        public TipoTripulacion()
        { }
        public string Tipo_Tripulacion
        {
            get
            {
                return tipoTripulacion;
            }
            set
            {
                if (value.Equals("Terramozo")||value.Equals("Cabina"))
                    tipoTripulacion = value;
            }
        }
        
    }
}
