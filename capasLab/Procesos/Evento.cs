using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capasLab
{
    public class Evento
    {
        String tipoEntrada;
        private int cantEntrada { get; set; }
        private int cantEstacionamiento { get; set; }
        //Sirve para restar al inicio del programa lo que se ha usado antes
        int[] cuposEntrada = { 10, 20, 120 }; //Platino,VIP,General respectivamente
        string[] tipos = { "Platino", "VIP", "General" };
        int cuposEstacionamiento = 200;

        //Para imprimir en el formulario factura
        public double montoTipo { get; set; }
        public double subtotal { get; set; }
        public double subtotal2 { get; set; }
        public double total { get; set; }
        public double sub1SPAC { get; set; }
        public double sub2ITBMS { get; set; }
        public double montoEntrada { get; set; }
        public double montoEstacionamiento { get; set; }

        public Evento(int usadoEstacionamiento, int usadoPlatino, int usadoVIP, int usadoGeneral)
        {
            tipoEntrada = "";
            cantEntrada = 0;
            cantEstacionamiento = 0;
            montoTipo = 0;
            subtotal = 0;
            total = 0;

            //Actualizo con lo que ya se ha utilizado anteriormente
            cuposEstacionamiento -= usadoEstacionamiento;
            RestarCuposEntrada(0, usadoPlatino);
            RestarCuposEntrada(1, usadoVIP);
            RestarCuposEntrada(2, usadoGeneral);
        }

        //Este método procesa los datos ingresados por el usuario y calcula los totales correspondientes.
        //Se llama cada vez que se presiona el botón calcular en el formulario
        public void ProcesarDatos(String tipoEntrada, int cantEntrada, int cantEstacionamiento)
        {
            this.tipoEntrada = tipoEntrada;
            this.cantEntrada = cantEntrada;
            this.cantEstacionamiento = cantEstacionamiento;
            montoTipo = 0;
            subtotal = 0;
            total = 0;


            //Luego de actualizar los cupos, procedemos a calcular todo lo que se necesita
            DeterminarTipoEntrada();
            CalcularEstacionamientosDisp(); //Restamos lo que usamos en estacionamiento actualmente y lo pasado
            CalcularSubtotal();
            CalcularSubtotal2();
            CalcularTotal();
        }
        void CalcularEstacionamientosDisp()
        {
            if (cantEstacionamiento <= cuposEstacionamiento && cantEstacionamiento > 0)
                cuposEstacionamiento -= cantEstacionamiento;
            else if (cantEstacionamiento > cuposEstacionamiento)
                MostrarAlerta("Ya no hay cupos de estacionamiento disponibles", "Error");
        }


        void CalcularTotal()
        {
            sub2ITBMS = subtotal2 * 0.07;
            total = Math.Round(subtotal2 + sub2ITBMS, 2);

        }
        void CalcularSubtotal()
        {
            montoEntrada = montoTipo * cantEntrada;
            montoEstacionamiento = cantEstacionamiento * 25;
            subtotal = Math.Round(montoEntrada + montoEstacionamiento, 2);

        }

        void CalcularSubtotal2()
        {
            sub1SPAC = montoEntrada * 0.05;

            subtotal2 = Math.Round(subtotal + sub1SPAC, 2);

        }

        void DeterminarTipoEntrada()
        {

            try
            {
                if (tipoEntrada == null)
                {
                    throw new ArgumentNullException();
                }

                switch (tipoEntrada)
                {
                    case "Platino": montoTipo += 150; RestarCuposEntrada(0); break;
                    case "VIP": montoTipo += 100; RestarCuposEntrada(1); break;
                    case "General": montoTipo += 50; RestarCuposEntrada(2); break;
                    default: MostrarAlerta("Elija una opción válida", "Advertencia"); break;
                }


            }
            catch (ArgumentNullException)
            {
                MostrarAlerta("Debe ingresar un tipo de entrada", "Advertencia");
            }
            catch (Exception)
            {
                MostrarAlerta("Ha ocurrido un error", "Error");
            }

        }

        void RestarCuposEntrada(int indice)
        {
            if (cantEntrada <= cuposEntrada[indice] && cantEntrada > 0)
                cuposEntrada[indice] -= cantEntrada;
            else if (cantEntrada > cuposEntrada[indice])
                MostrarAlerta("Ya no quedan cupos para este tipo de entrada (" + tipos[indice] + ") , Disculpe las molestias", "Error");
            // Si cantEntrada == 0, no hace nada
        }

        //Este sirve para cuando queremos restar una cantidad personalizada y no lo que insertó la persona en el momento,
        //Por ejemplo para restar las cantidades anteriores

        void RestarCuposEntrada(int indice, int cantRestar)
        {
            if (cantRestar <= cuposEntrada[indice] && cantRestar > 0)
                cuposEntrada[indice] -= cantRestar;
            else if (cantRestar > cuposEntrada[indice])
                MostrarAlerta("Ya no quedan cupos para este tipo de entrada (" + tipos[indice] + ") , Disculpe las molestias", "Error");
            // Si cantRestar == 0, no hace nada
        }

        void MostrarAlerta(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public int TraerCupoPlatino()
        {
            return cuposEntrada[0];
        }
        public int TraerCupoVIP()
        {
            return cuposEntrada[1];
        }
        public int TraerCupoGeneral()
        {
            return cuposEntrada[2];
        }

        public int TraerCupoEstacionamiento()
        {
            return cuposEstacionamiento;
        }
    }
}
