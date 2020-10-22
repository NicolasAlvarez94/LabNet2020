using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosTransporte : IDaoTransporte
    {
        // LISTA PARA GUARDAR INSTANCIAS DE TIPO TRANSPORTE.
        private List<Transporte> transportes;

        public DatosTransporte() {         
            this.transportes = new List<Transporte>();
        }

            
        #region Metodos Publicos
        public void AgregarTransporte(Transporte transporte) {         
            transportes.Add(transporte);
        }

        public List<Transporte> ObtenerTransportes() {         
            return transportes;
        }
        #endregion
    }
}
