using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Administrativo:Empleado
    {
        
        public Administrativo() { }
        public Administrativo(string Dni, int Empleado_ID, double Sueldo) : base(Dni, Empleado_ID, 1500.0) { }
        public void Identificarse()
        {           
            Console.WriteLine("Soy un empleado del área de administración mi DNI es: "+Dni);
            Console.ReadLine();
        }
    }
}
