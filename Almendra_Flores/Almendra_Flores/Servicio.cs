using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    public abstract class Servicio
    {
        public string InfoServicio
        {
            get; set;
        }
        public double CostoServicio
        {
            get;set;
        }
        public Servicio()
        { }
        public Servicio(string _InfoServicio,double _CostoServicio)
        {
            InfoServicio = _InfoServicio;
            CostoServicio = _CostoServicio;
        }
       
        public abstract void Info();
    }
}
