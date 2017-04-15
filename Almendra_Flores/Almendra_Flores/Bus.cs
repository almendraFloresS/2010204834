using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Bus
    {
        private List<Tripulacion> _Tripulacion;
        private int N_Asientos
        {
            get; set;
        }
        private string Tipo
        { get; set;
        }
        public List<Tripulacion> Tripulacion
        {
            get
            {
                return _Tripulacion;
            }
            set
            {
                if (value.Count == 12)
                    _Tripulacion = value;
            }
        }
        public Bus()
        { }
        public Bus(List<Tripulacion> _Tripulacion)
        {
            Tripulacion = _Tripulacion;
        }
        public Bus(int _N_Asientos, string _Tipo)
        {
            N_Asientos = _N_Asientos;
            Tipo = _Tipo;
        }
        
    }
}
