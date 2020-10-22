using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Automovil: Transporte
    {
        #region Constructor
        public Automovil(int pasajeros, string tipoTransporte): base(pasajeros, tipoTransporte) { }
        #endregion

        #region Metodos Publicos 
        public override string Avanzar() {         
            string datoAvanze = $"{base.Avanzar()} A TRAVES DEL SUELO";
            return datoAvanze;
        }

        public override string Detenerse() {
            string datoDetencion = $"{base.Detenerse()} A TRAVES DE UN PEDAL";
            return datoDetencion;
        }
        #endregion

    }
}
