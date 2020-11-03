using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.ExtensionImplementDAO;
using Data.Dao.Context;

namespace Data.Dao.ImplementDAO
{
    public class CategoryImplementDAO : BaseContextDAO, IEntityDAO<Category>
    {
        
        public CategoryImplementDAO() {
            dbContext = base.GetSingleInstanceContext();
        }


        #region Metodos Publicos

        // Metodos de Acceso a Datos, Invocados en la Capa de Logica.

        public void RegisterEntity(Category category) {
            try {             
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) {throw ex;}                                        
            catch (Exception ex) { throw ex; }
        }


        public List<Category> GetListEntities() {
            try {             
                var listCategories = dbContext.Categories.ToList();
                return listCategories;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void DeleteEntity(int id) {
            try {             
                var objCategorie = dbContext.Categories.First(c => c.CategoryID.Equals(id));
                dbContext.Categories.Remove(objCategorie);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void UpdateEntity(Category category) {
            try {             
                var objCategorie = dbContext.Categories.First(c => c.CategoryID.Equals(category.CategoryID));
                objCategorie.CategoryName = category.CategoryName;
                objCategorie.Description = category.Description;
                objCategorie.Picture = category.Picture;
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public Category GetEntityByID(int id) {
            try {             
                var objCategory = (from category in dbContext.Categories
                                   where category.CategoryID == id
                                   select category).First();
                return objCategory;
            }
            catch (InvalidOperationException ex) {throw ex;}
            catch (Exception ex) {throw ex;}                                  
        }    

        #endregion

    }
}
