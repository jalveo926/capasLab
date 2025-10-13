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
        int cuposEstacionamiento=200; //200

        Double monto,subtotal, total;


        Evento(int cantEntrada,int cantEstacionamiento,int usadoEstacionamiento,int usadoPlatino,int usadoVIP,int usadoGeneral) { 
            this.cantEntrada = cantEntrada;
            this.cantEstacionamiento = cantEstacionamiento;
            monto = 0;
            subtotal = 0;
            total = 0;

            //Actualizo con lo que ya se ha utilizado anteriormente
            cuposEstacionamiento -= usadoEstacionamiento + cantEstacionamiento; //Restamos lo que usamos en estacionamiento y lo pasado
            RestarCuposEntrada(0, usadoPlatino);
            RestarCuposEntrada(1, usadoVIP);
            RestarCuposEntrada(2, usadoGeneral);
            

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
                    case "Platino": monto += 150; RestarCuposEntrada(0); break;
                    case "VIP": monto += 100; RestarCuposEntrada(1); break;
                    case "General": monto += 50; RestarCuposEntrada(2); break;
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
            if (cuposEntrada[indice] >= 0)
                cuposEntrada[indice] -= cantEntrada;
            else {
                MostrarAlerta("Se acabaron los cupos para este tipo de entrada,Disculpe las molestias","Error");
                return;
            }
        }

        //Este sirve para cuando queremos restar una cantidad personalizada y no lo que inserto la persona en el momento,
        //Por ejemplo para restar las cantidades anteriores
        
        void RestarCuposEntrada(int indice,int cantRestar)
        {
            if (cuposEntrada[indice] >= 0)
                cuposEntrada[indice] -= cantRestar;
            else
            {
                MostrarAlerta("Se acabaron los cupos para este tipo de entrada,Disculpe las molestias", "Error");
                return;
            }
        }

        void MostrarAlerta(String mensaje,String titulo) {
            MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        int TraerCupoPlatino() {
            return cuposEntrada[0];
        }
        int TraerCupoVIP(){
            return cuposEntrada[1];
        }
        int TraerCupoGeneral() {
            return cuposEntrada[2];
        }

       
        
    }
}
