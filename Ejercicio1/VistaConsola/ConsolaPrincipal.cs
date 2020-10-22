using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Datos;

namespace VistaConsola
{
    class ConsolaPrincipal
    {
        // REFERENCIA DE TIPO DATOSTRANSPORTE PARA GUARDAR INSTANCIAS DE TIPO TRANSPORTE.
        private IDaoTransporte transporteDatos;


        public ConsolaPrincipal() {         
            this.transporteDatos = new DatosTransporte();
            this.CrearYGuardarTransportes();
        }
        


        // METODO PUBLICO INVOCADO EN LA METODO PRINCIPAL DE LA CLASE PROGRAM
        public void MostrarDatosTransporte() {         
            List<Transporte> transportes = transporteDatos.ObtenerTransportes();

            foreach (Transporte transporte in transportes) {             
                string strTransporte = DeterminarTransporte(transporte);
                Console.WriteLine($"{strTransporte} TIPO: {transporte.TipoTransporte}");

                // POLIMORFISMO EL COMPORTAMINETO DEL OBJETO SE ESTABLECE EN TIEMPO DE EJECUCION DE ACUERDO AL TIPO. 
                Console.WriteLine(transporte.Avanzar());
                Console.WriteLine(transporte.Detenerse());
                Console.WriteLine();
            }
        }



        #region Metodos Privados        
        private void CrearYGuardarTransportes()
        {
            Transporte objAutomovil1 = new Automovil(2, "TERRESTRE");
            Transporte objAutomovil2 = new Automovil(4, "TERRESTRE");
            Transporte objAutomovil3 = new Automovil(5, "TERRESTRE");
            Transporte objAutomovil4 = new Automovil(3, "TERRESTRE");
            Transporte objAutomovil5 = new Automovil(6, "TERRESTRE");
            Transporte objAvion1 = new Avion(200, "AEREO");
            Transporte objAvion2 = new Avion(250, "AEREO");
            Transporte objAvion3 = new Avion(150, "AEREO");
            Transporte objAvion4 = new Avion(100, "AEREO");
            Transporte objAvion5 = new Avion(260, "AEREO");

            transporteDatos.AgregarTransporte(objAutomovil1);
            transporteDatos.AgregarTransporte(objAutomovil2);
            transporteDatos.AgregarTransporte(objAutomovil3);
            transporteDatos.AgregarTransporte(objAutomovil4);
            transporteDatos.AgregarTransporte(objAutomovil5);
            transporteDatos.AgregarTransporte(objAvion1);
            transporteDatos.AgregarTransporte(objAvion2);
            transporteDatos.AgregarTransporte(objAvion3);
            transporteDatos.AgregarTransporte(objAvion4);
            transporteDatos.AgregarTransporte(objAvion5);
        }


        private string DeterminarTransporte(Transporte transporte) {         
            if (transporte is Avion)
                return "ESTE TRANSPORTE ES UN AVION - ";
            else
                return "ESTE TRANSPORTE ES UN AUTOMOVIL - ";
        }

        #endregion

    }
}
