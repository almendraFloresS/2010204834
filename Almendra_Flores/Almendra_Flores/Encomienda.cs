using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Encomienda:Servicio
    {
        LugarViaje _LugarViaje = new LugarViaje();
        private string Descripcion
        {
            get;set;
        }
        private string N_Encomienda
        {
          get; set;
        }
        private double Peso
        {
            get; set;
        }
        private string Destinatario
        {
            get;set;
        }
        public Bus Bus
        {
            get; set;
        }
     

        public Encomienda(string _InfoServicio,double _CostoServicio) : base(_InfoServicio,_CostoServicio) { }
        public Encomienda(Bus _Bus)
        {
            Bus = _Bus;
        }
        public Encomienda(string _N_Encomienda, double _Peso,string _Destinatario)
        {
            N_Encomienda = _N_Encomienda;
            Peso = _Peso;
            Destinatario = _Destinatario;
        }

        public override void Info()
        {
            Console.WriteLine("                       INFO DE ENCOMIENDAS");
            int count = 1;
            while (count <= 2)
            {
                if (count == 1)
                {
                    N_Encomienda = "7101098";
                    Descripcion = "Piña";
                    _LugarViaje.Departamento = "Tacna";
                    _LugarViaje.Ciudad = "Tarata";
                    Peso = 52.0;
                }
                else
                {
                    N_Encomienda = "0239520";
                    Descripcion = "Ropa Variada";
                    _LugarViaje.Departamento = "La Libertad";
                    _LugarViaje.Ciudad = "Huamachuco";
                    Peso = 12;
                }
                count++;
                Console.WriteLine("N° Encomienda: {0}\nDescripcion: {1}\nPeso: {2}kg\nDestino: {3} - {4}\n", N_Encomienda, Descripcion, Peso, _LugarViaje.Ciudad, _LugarViaje.Departamento);
            }
            Console.Read();
        }
        public Encomienda() { }
    }
}
