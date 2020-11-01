using Data.Dao.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Dao.ImplementDAO;
using Data.Dao.ExtensionImplementDAO;

namespace Logic
{
    public class CategoryLogic
    {
        private ICategoryDAO categoryDAO;

        public CategoryLogic() {
            this.categoryDAO = new CategoryImplementDAO();           
        }


        #region Metodos Publicos

        // Metodos de Logica, Recibe Peticiones y Eventos de la Capa Presentacion y Delega la tarea a la Capa de Datos.

        public void RegisterCategory(Category category) {
            categoryDAO.RegisterCategory(category);
        }

        public List<Category> ListCategories() {
            var listCategories = categoryDAO.ListCategories();
            return listCategories;
        }

        public void DeleteCategory(int id) {
            categoryDAO.DeleteCategory(id);
        }

        public void UpdateCategory(Category category) {
            categoryDAO.UpdateCategory(category);
        }

        public Category GetCategoryID(int id) {         
            var objCategory = categoryDAO.GetCategoryByID(id);
            return objCategory;
        }

        public List<string> GetCategoryNames() {
            var listCategoryNames = categoryDAO.GetCategoryNames();
            return listCategoryNames;
        }

        public int GetNumberCategories() {
            var intNumbreCategories = categoryDAO.GetNumberCategories();
            return intNumbreCategories;
        }

        #endregion

    }
}
