using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capasLab.Procesos
{
    internal class pruebaEvento
    {
        public  void prueba()
        {
            Evento evento = new Evento(1,1,1,1);
            
            evento.ProcesarDatos("VIP", 3,2);
            Console.WriteLine(evento.total);
            Console.WriteLine(evento.TraerCupoEstacionamiento());
            evento.ProcesarDatos("Platino", 10,1);
            Console.WriteLine(evento.total);
            Console.WriteLine(evento.TraerCupoEstacionamiento());
        }
            
           
        
    }
}
