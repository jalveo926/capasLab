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
        int cantEntrada { get; set; }
        int cantEstacionamiento { get; set; }
        //Sirve para restar al inicio del programa lo que se ha usado antes
        int[] cuposEntrada = { 10, 20, 120 }; //Platino,VIP,General respectivamente
        int cuposEstacionamiento = 200; //200

        public double montoTipo { get; set; }
        public double subtotal { get; set; }
        public double subtotal2 { get; set; }
        public double total { get; set; }
        public double sub1SPAC { get; set; }
        public double sub2ITBMS { get; set; }
        public double montoEntrada { get; set; }
        public double montoEstacionamiento { get; set; }


        public Evento(String tipoEntrada,int cantEntrada,int cantEstacionamiento,int usadoEstacionamiento,int usadoPlatino,int usadoVIP,int usadoGeneral) { 
            this.tipoEntrada = tipoEntrada;
            this.cantEntrada = cantEntrada;
            this.cantEstacionamiento = cantEstacionamiento;
            montoTipo = 0;
            subtotal = 0;
            total = 0;

            //Actualizo con lo que ya se ha utilizado anteriormente
            CalcularEstacionamientosDisp(usadoEstacionamiento); //Restamos lo que usamos en estacionamiento actualmente y lo pasado
            RestarCuposEntrada(0, usadoPlatino);
            RestarCuposEntrada(1, usadoVIP);
            RestarCuposEntrada(2, usadoGeneral);
            //Luego de actualizar los cupos, procedemos a calcular todo lo que se necesita
            DeterminarTipoEntrada();

        }
       public void ProcesarDatos() {
            CalcularEntradas();
            CalcularEstacionamiento();
            CalcularSubtotal();
            CalcularSPAC();
            CalcularSubtotal2();
            CalcularITBMS();
            CalcularTotal();
        }
          void CalcularEstacionamientosDisp(int usados) {
            cuposEstacionamiento -= usados + cantEstacionamiento;
        }

        //Estos métodos se llaman desde otra clase para poder tener cada dato por separado por eso tantos procesos simples
         void CalcularTotal() {
            total = subtotal2 + sub2ITBMS;
         
        }
         void CalcularSubtotal() {
            subtotal = montoEntrada + montoEstacionamiento;
           
        }

         void CalcularSubtotal2() {
            subtotal2 = subtotal + sub1SPAC;
            
        }

          void CalcularEntradas() {
            
            montoEntrada = montoTipo * cantEntrada;
         
        }


         void CalcularEstacionamiento() {
            montoEstacionamiento= cantEstacionamiento * 25;
        }

        void CalcularSPAC() {
           sub1SPAC = montoEntrada * 0.05;
          
        }

        void CalcularITBMS() {
            sub2ITBMS = subtotal2 * 0.07;
            
        }

        void DeterminarTipoEntrada() {

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
            catch (Exception) {
                MostrarAlerta("Ha ocurrido un error", "Error");   
            }
            
        }

        void RestarCuposEntrada(int indice) {
            if (cuposEntrada[indice] >= 0 && (cuposEntrada[indice]-cantEntrada >=0))
                cuposEntrada[indice] -= cantEntrada;
            else {
                MostrarAlerta("Quedan "+ (cuposEntrada[indice] - cantEntrada) + " para este tipo de entrada,Disculpe las molestias","Error");
                return;
            }
        }

        //Este sirve para cuando queremos restar una cantidad personalizada y no lo que inserto la persona en el momento,
        //Por ejemplo para restar las cantidades anteriores
        
        void RestarCuposEntrada(int indice,int cantRestar)
        {
            if (cuposEntrada[indice] >= 0 && (cuposEntrada[indice] - cantEntrada >= 0))
                cuposEntrada[indice] -= cantRestar;
            else
            {
                MostrarAlerta("Quedan " + (cuposEntrada[indice] - cantEntrada) + " para este tipo de entrada,Disculpe las molestias", "Error");
                return;
            }
        }

        void MostrarAlerta(String mensaje,String titulo) {
            MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        public int TraerCupoPlatino() {
            return cuposEntrada[0];
        }
        public int TraerCupoVIP(){
            return cuposEntrada[1];
        }
        public int TraerCupoGeneral() {
            return cuposEntrada[2];
        }

        public int TraerCupoEstacionamiento() {
            return cuposEstacionamiento;
        }



    }
}
