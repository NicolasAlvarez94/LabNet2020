using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Datos;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        // INSTANCIA DE TIPO DATOSTRANSPORTE PARA GUARDAR INSTANCIAS DE TIPO TRANSPORTE.
        private IDaoTransporte transporteDatos = new DatosTransporte();


        // CONSTRUCTOR, INICIALIZA COMPONENTES Y SUSCRIBE A EVENTOS.
        public FrmPrincipal() {         
            this.InitializeComponent();
            this.CrearYGuardarTransportes();
            this.btnOperaciones.Enabled = false;
            this.btnMostrar.Click += MostrarDatos;
            this.btnOperaciones.Click += MostrarOperaciones;
            this.btnSalir.Click += SalirAplicacion;
        }


        // SE CREAN INSTANCIAS DE TRANSPORTE Y SE GUARDAN EN UNA LISTA PRIVADA, DEFINIDA EN LA CLASE DATOSTRANSPORTE. 
        private void CrearYGuardarTransportes() {            
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


        // AL HACER CLICK EN EL BOTON: MOSTRARTRANSPORTES, SE CARGA EL CONTROL CON LOS DATOS DE LA LISTA DE TIPO TRANSPORTE.
        private void MostrarDatos(object sender, EventArgs e) {         
            dgvDatosTransportes.AutoGenerateColumns = true;
            dgvDatosTransportes.DataSource = transporteDatos.ObtenerTransportes();
            MessageBox.Show("ELEGIR REGISTRO Y HACER CLICK EN VER OPERACIONES");
            btnOperaciones.Enabled = true;
        }



        // OBTIENE LOS DATOS DEL CONTROL DATAGRIDVIEW Y CREA UN OBJETO PARA LUEGO PASARSELO A UN SEGUNDO FORMULARIO PARA MOSTRAR SUS DATOS 
        private void MostrarOperaciones(object sender, EventArgs e) {
            Transporte objTransporte = null;                                
            string tipo = dgvDatosTransportes.CurrentRow.Cells["TipoTransporte"].Value.ToString();                                                   
            int pasajeros = Convert.ToInt32(dgvDatosTransportes.CurrentRow.Cells["Pasajeros"].Value);

            switch (tipo) {             
                case "TERRESTRE":
                    objTransporte = new Automovil(pasajeros, tipo);
                    break;
                case "AEREO":
                    objTransporte = new Avion(pasajeros, tipo);
                    break;
            }
            
            FrmMostrarOperaciones formularioOperaciones = new FrmMostrarOperaciones(objTransporte);
            formularioOperaciones.StartPosition = FormStartPosition.CenterScreen;
            formularioOperaciones.Show();
        }

       
        private void SalirAplicacion(object sender, EventArgs e) {         
            this.Close();
        }



    }
}
