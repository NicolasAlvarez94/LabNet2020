using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Dao.ExtensionImplementDAO
{
    public static class CategoryImplementDaoExtensions
    {
        private static NorthwindContext dbContext = new NorthwindContext();


        // Metodos de Extension de Acesso a Datos, Extienden la Funcionalidad de CategoryImplementDAO.

        public static Category GetCategoryByID(this ICategoryDAO ICategory, int id) {
            try {
                var objCategory = (from category in dbContext.Categories
                                   where category.CategoryID == id
                                   select category).First();
                return objCategory;
            }
            catch(Exception ex) {
                throw ex;
            }            
        }


        public static List<string> GetCategoryNames(this ICategoryDAO ICategory) {
            try {
                var listCategoryNames = (from category in dbContext.Categories
                                   select category.CategoryName).ToList();
                return listCategoryNames;
            }
            catch (Exception ex) {             
                throw ex;
            }
        }


        public static int GetNumberCategories(this ICategoryDAO ICategory) {
            try {
                var intNumbreCategories = (from category in dbContext.Categories
                                           select category).Count();
                return intNumbreCategories;
            }
            catch (Exception ex) {             
                throw ex;
            }
        }

    }
}
