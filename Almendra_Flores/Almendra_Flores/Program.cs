using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almendra_Flores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(65, 30);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Empresa de Transportes Almendra SAC";
            var Transporte = new Transporte();
            Transporte.Info();
            var Encomienda = new Encomienda();
            Encomienda.Info();
            Console.ReadLine();
        }
    }
}
