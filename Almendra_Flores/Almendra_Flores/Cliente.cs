using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Cliente
    {
        public string Nombre
        {
            get; set;
        }
        public string Apellido
        {
            get;set;
        }
        public string Dni
        {
            get; set;
        }
        public Cliente()
        { }
        public Cliente(string Nombre)
        {
            Nombre = this.Nombre;
        }
       
    }
}
