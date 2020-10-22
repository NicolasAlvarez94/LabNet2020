using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Avion: Transporte
    {

        #region Constructor
        public Avion(int pasajeros, string tipoTransporte) : base(pasajeros, tipoTransporte) { }                    
        #endregion

        #region Metodos Publicos
        public override string Avanzar() {         
            string datoAvance = $"{base.Avanzar()} A TRAVES DEL AIRE";
            return datoAvance;
        }

        public override string Detenerse() {         
            string datoDetencion = $"{base.Detenerse()} A TRAVES DE PEDALES Y ALERONES";
            return datoDetencion;
        }
        #endregion
    }
}
