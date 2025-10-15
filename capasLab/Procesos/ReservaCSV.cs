using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace capasLab
{
    public class ReservaCSV
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

        public static (int usadosEst, int usadosPlatino, int usadosVIP, int usadosGeneral) LeerTotalesUsados()
        {
            int usadosEst = 0, usadosPlatino = 0, usadosVIP = 0, usadosGeneral = 0;

            try
            {
                if (!File.Exists(Archivo))
                    return (0, 0, 0, 0);

                using (var sr = new StreamReader(Archivo))
                {
                    string linea;
                    bool primera = true;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (primera) { primera = false; continue; }
                        var datos = linea.Split(',');
                        usadosPlatino += int.Parse(datos[2]);
                        usadosVIP += int.Parse(datos[3]);
                        usadosGeneral += int.Parse(datos[4]);
                        usadosEst += int.Parse(datos[5]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer registros previos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (usadosEst, usadosPlatino, usadosVIP, usadosGeneral);
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
