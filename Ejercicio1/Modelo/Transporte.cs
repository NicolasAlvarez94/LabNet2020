using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Transporte : ITransporte
    {
        #region Atributos Privados      
        private int pasajeros;
        private string tipoTransporte;
        #endregion


        #region Constructor
        public Transporte(int pPasajeros, string pTipoTransporte) {         
            this.pasajeros = pPasajeros;
            this.tipoTransporte = pTipoTransporte;
        }
        #endregion


        #region Propiedades
        public int Pasajeros {         
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }

        public string TipoTransporte {         
            get { return this.tipoTransporte; }
            set { this.tipoTransporte = value; }
        }
        #endregion


        #region Metodos Publicos
        public virtual string Avanzar() {
            return "AVANZA";
        }

        public virtual string Detenerse() {
            return "SE DETIENE";
        }
        #endregion

    }
}
