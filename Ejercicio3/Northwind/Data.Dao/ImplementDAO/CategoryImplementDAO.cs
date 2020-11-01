using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.ExtensionImplementDAO;

namespace Data.Dao.ImplementDAO
{
    public class CategoryImplementDAO : ICategoryDAO
    {

        private NorthwindContext dbContext;

        public CategoryImplementDAO() {
            this.dbContext = this.GetSingleInstanceContext();
        }

        // Singleton.
        private NorthwindContext GetSingleInstanceContext() {         
            bool validateSingleInstance = this.dbContext == null;

            if (validateSingleInstance) {             
                this.dbContext = new NorthwindContext();
            }
            return dbContext;
        }



        #region Metodos Publicos

        // Metodos de Acceso a Datos, Invocados en la Capa de Logica.

        public void RegisterCategory(Category category) {
            try {             
                this.dbContext.Categories.Add(category);
                this.dbContext.SaveChanges();
            }
            catch(InvalidOperationException ex) {
                throw ex;
            } 
            catch(Exception ex) {throw ex;}
        }


        public List<Category> ListCategories() {
            try {             
                var listCategories = dbContext.Categories.ToList();
                return listCategories;
            }                                   
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void DeleteCategory(int id) {
            try {
                var objCategorie = dbContext.Categories.First(c => c.CategoryID.Equals(id));
                dbContext.Categories.Remove(objCategorie);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) {throw ex;}                                         
            catch (Exception ex) { throw ex; }
        }


        public void UpdateCategory(Category category) {         
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

        #endregion

    }
}
