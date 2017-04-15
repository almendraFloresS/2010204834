using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Tripulacion:Empleado
    {
        private List<TipoTripulacion> _TipoTripulacion;
        public Tripulacion() { }
        public Tripulacion(string Dni, int Empleado_ID, double Sueldo) : base(Dni, Empleado_ID,900.0) { }
        public Tripulacion(int N_Tripulantes)
        {
            _TipoTripulacion = new List<TipoTripulacion>(N_Tripulantes);
        }
        public void Identificarse()
        {
            Console.WriteLine("Soy un empleado del área de tripulación mi DNI es: " + Dni);
            Console.ReadLine();
        }
        public void N_Tripulantes()
        {
            int N_Tripulantes = _TipoTripulacion.Count();
            Console.WriteLine("El número de tripulantes que irán abordo es: " + N_Tripulantes);
            Console.ReadLine();
        }
    }
}
