using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Transporte:Servicio
    {
        public override void Info()
        {

            Cliente _Cliente = new Cliente();
            TipoViaje _TipoViaje = new TipoViaje();
            LugarViaje _LugarViaje = new LugarViaje();
            Console.WriteLine("                            INFO DE VIAJES");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    _TipoViaje.Tipo = "VIP   ";
                    _Cliente.Nombre = "Miriam";
                    _Cliente.Apellido = "Hernandez";
                    _Cliente.Dni = "18283500";
                    _LugarViaje.Departamento = "Arequipa";
                    _LugarViaje.Ciudad = "Achoma";
                }
                else if (i == 1)
                {
                    _TipoViaje.Tipo = "VIP    ";
                    _Cliente.Nombre = "Enrique";
                    _Cliente.Apellido = "Iglesias";
                    _Cliente.Dni = "35650221";
                    _LugarViaje.Departamento = "Junin";
                    _LugarViaje.Ciudad = "Jauja";
                }
                else
                {
                    _TipoViaje.Tipo = "Normal";
                    _Cliente.Nombre = "Joey";
                    _Cliente.Apellido = "Montana";
                    _Cliente.Dni = "48867447";
                    _LugarViaje.Departamento = "Ica";
                    _LugarViaje.Ciudad = "Nazca";
                }
                 Console.WriteLine("Cliente: {0} {1}\nDni: {2}\nTipo de Bus: {3}\nDestino: {4} - {5}\n",_Cliente.Nombre,_Cliente.Apellido,_Cliente.Dni,_TipoViaje.Tipo,_LugarViaje.Ciudad,_LugarViaje.Departamento);
            }

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
        }
        public Transporte() { }
    }
}
