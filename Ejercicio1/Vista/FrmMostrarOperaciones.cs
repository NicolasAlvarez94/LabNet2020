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

namespace Vista
{
    public partial class FrmMostrarOperaciones : Form
    {
        private Transporte objTransporte;
        public FrmMostrarOperaciones(Transporte transporte)
        {
            this.InitializeComponent();
            this.objTransporte = transporte;
            this.MostrarDatosYComportamiento();
            this.btnCerrar.Click += CerrarFormulario;

        }


        private void MostrarDatosYComportamiento() {         
            if (objTransporte is Avion)
                lblTransporte.Text = "TRANSPORTE AVION - ";
            else
                lblTransporte.Text = $"TRANSPORTE AUTOMOVIL - ";

            lblTransporte.Text += $"TIPO: {objTransporte.TipoTransporte} - CANTIDAD PASAJEROS: {objTransporte.Pasajeros}";

            // POLIMORFISMO.
            lblAccionA.Text = objTransporte.Avanzar();
            lblAccionB.Text = objTransporte.Detenerse();
        }


        private void CerrarFormulario(object sender, EventArgs e) {         
            this.Close();
        }
    }
}
