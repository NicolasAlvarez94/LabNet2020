using Datos.Contexto;
using Datos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ImplementacionDAO
{
    public class RegionImplementacionDAO : BaseContextDAO, IEntidadDAO<Region>
    {
        #region Metodos Publicos
        public void RegistrarEntidad(Region pRegion) {
            try {             
                bdContext.Regions.Add(pRegion);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void EliminarEntidad(int id) {
            try {             
                var objRegion = (from region in bdContext.Regions
                                 where region.RegionID == id
                                 select region).First();

                bdContext.Regions.Remove(objRegion);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public List<Region> TraerDatos() {
            try {             
                var listaRegiones = (from region in bdContext.Regions
                                     select region).ToList();
                return listaRegiones;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void ModificarEntidad(Region pRegion) {
            try {             
                var objRegion = (from region in bdContext.Regions
                                 where region.RegionID == pRegion.RegionID
                                 select region).First();

                objRegion.RegionDescription = pRegion.RegionDescription;                               
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }            
        }

        #endregion
    }
}
