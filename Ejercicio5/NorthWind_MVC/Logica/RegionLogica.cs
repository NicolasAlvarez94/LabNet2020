using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ImplementacionDAO;
using Datos.Interfaces;
using Entidades;

namespace Logica
{
    public class RegionLogica
    {
        private readonly IEntidadDAO<Region> regionDAO;

        public RegionLogica() {
            this.regionDAO = new RegionImplementacionDAO();
        }

        #region Metodos Publicos
        public void RegistrarRegion(Region pRegion) {
            this.regionDAO.RegistrarEntidad(pRegion);
        }

        public void EliminarRegion(int id) {
            this.regionDAO.EliminarEntidad(id);        
        }

        public List<Region> TraerDatos() {         
            List<Region> listaRegiones = this.regionDAO.TraerDatos();
            return listaRegiones;
        }

        public void ModificarRegion(Region pRegion) {
            this.regionDAO.ModificarEntidad(pRegion); 
        }
        #endregion
    }
}
