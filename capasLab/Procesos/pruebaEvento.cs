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
            Evento evento = new Evento(usadoEstacionamiento: 1, usadoPlatino: 0, usadoVIP: 0, usadoGeneral: 1);

            // --- Primer evento: VIP ---
            evento.ProcesarDatos("VIP", 20, 2);
            Console.WriteLine("=== Después de vender 20 VIP y 2 estacionamientos ===");
            Console.WriteLine($"Total: {evento.total}");
            Console.WriteLine($"Cupos VIP restantes: {evento.TraerCupoVIP()}");
            Console.WriteLine($"Cupos Estacionamiento restantes: {evento.TraerCupoEstacionamiento()}\n");

            // --- Segundo evento: Platino ---
            evento.ProcesarDatos("Platino", 10, 1);
            Console.WriteLine("=== Después de vender 10 Platino y 1 estacionamiento ===");
            Console.WriteLine($"Total: {evento.total}");
            Console.WriteLine($"Cupos Platino restantes: {evento.TraerCupoPlatino()}");
            Console.WriteLine($"Cupos Estacionamiento restantes: {evento.TraerCupoEstacionamiento()}\n");

            // --- Tercer evento: General (prueba límite) ---
            evento.ProcesarDatos("General", 120, 5); // Intentamos vender más de lo disponible
            Console.WriteLine("=== Después de intentar vender 120 General y 5 estacionamientos ===");
            Console.WriteLine($"Total: {evento.total}");
            Console.WriteLine($"Cupos General restantes: {evento.TraerCupoGeneral()}");
            Console.WriteLine($"Cupos Estacionamiento restantes: {evento.TraerCupoEstacionamiento()}\n");

        }



    }
}
