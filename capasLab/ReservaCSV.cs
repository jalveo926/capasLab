using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capasLab
{
    internal class ReservaCSV
    {
        private static readonly string Carpeta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "ReservaEntradas");

        private static readonly string Archivo = Path.Combine(Carpeta, "reserva_entradas.csv");

        public static void Guardar(Reservas r)
        {
            try
            {
               if (!Directory.Exists(Carpeta))
                {
                    Directory.CreateDirectory(Carpeta);
                }

                bool archivoNuevo = !File.Exists(Archivo);

                using (var fs = new FileStream(Archivo, FileMode.Append, FileAccess.Write, FileShare.Read))
                using (var sw = new StreamWriter(fs, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
                {
                    if (archivoNuevo)
                    {
                        sw.WriteLine("Fecha,CantidadEntradas,TipoPlatino,TipoVIP,TipoGeneral,CantidadEstacionamiento");
                    }

                    sw.WriteLine(string.Join(",",
                        Csv(r.Fecha.ToString("yyyy-MM-dd HH:mm:ss")),
                        Csv(r.CantidadEntradas.ToString()),
                        Csv(r.TipoPlatino.ToString()),
                        Csv(r.TipoVIP.ToString()),
                        Csv(r.TipoGeneral.ToString()),
                        Csv(r.CantidadEstacionamiento.ToString())
                    ));
                }
            }
            catch (IOException ex)
            {
                throw new IOException("Error al guardar el archivo CSV: " + ex.Message, ex);
            }
        }
        private static string Csv(string valor)
        {
            if (valor is null)
            {
                return "";
            }
            bool requiereComillas = valor.Contains(',') || valor.Contains('"') ||
                                    valor.Contains('\n') || valor.Contains('\r');
            string limpio = valor.Replace("\"", "\"\"");
            return requiereComillas ? $"\"{limpio}\"" : limpio;
        }
    }
}
