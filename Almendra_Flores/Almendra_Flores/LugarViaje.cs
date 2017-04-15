using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class LugarViaje
    {
        public string Departamento
        {
            get; set;
        }
        public string Ciudad
        {
            get;set;
        }
        public LugarViaje()
        { }
        public LugarViaje(string _Departamento,string _Ciudad)
        {
            TipoViaje _TipoViaje = new TipoViaje();
            Departamento = _Departamento;
            Ciudad = _Ciudad;
        }
        
    }
}
