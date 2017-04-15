using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Empleado
    {
        public string Dni
        {
            get; set;
        }
        public double Sueldo
        {
            get; set;
        }
        public int Empleado_ID
        {
            get; set;
        }
        
        public Empleado()
        { }
        public Empleado(string Dni, int Empleado_ID, double Sueldo)
        {
            Dni = this.Dni;
            Empleado_ID = this.Empleado_ID;
            Sueldo = this.Sueldo;
        }
    }
}
