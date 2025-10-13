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
            Evento evento = new Evento("VIP", 3, 2, 1, 1, 1, 1);
            
            evento.ProcesarDatos();
            Console.WriteLine(evento.total);
        }
            
           
        
    }
}
