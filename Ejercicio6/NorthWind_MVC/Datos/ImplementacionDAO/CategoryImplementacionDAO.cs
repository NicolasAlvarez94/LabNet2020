using Datos.Contexto;
using Datos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ImplementacionDAO
{

    #region Metodos Publicos
    public class CategoryImplementacionDAO : BaseContextDAO, IEntidadDAO<Category>
    {
        public void RegistrarEntidad(Category pCategoria) {
            try {
                bdContext.Categories.Add(pCategoria);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) {throw ex;}
            catch (Exception ex) { throw ex; }
        }


        public void EliminarEntidad(int id) {
            try {
                var objCategoria = (from categoria in bdContext.Categories
                                    where categoria.CategoryID == id
                                    select categoria).First();

                bdContext.Categories.Remove(objCategoria);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public List<Category> TraerDatos() {
            try {             
                var listaCategorias = (from categoria in bdContext.Categories                                       
                                       select categoria).ToList();
                return listaCategorias;                
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void ModificarEntidad(Category pCategoria) {
            try {             
                var objCategoria = (from categoria in bdContext.Categories
                                    where categoria.CategoryID == pCategoria.CategoryID
                                    select categoria).First();

                objCategoria.CategoryName = pCategoria.CategoryName;
                objCategoria.Description = pCategoria.Description;
                objCategoria.Picture = pCategoria.Picture;
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion
    }
}
