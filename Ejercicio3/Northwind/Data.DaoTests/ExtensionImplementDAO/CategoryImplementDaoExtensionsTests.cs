using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Dao.ExtensionImplementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.InterfacesDAO;
using Data.Dao.ImplementDAO;
using Entities;


namespace Data.Dao.ExtensionImplementDAO.Tests
{
    [TestClass()]
    public class CategoryImplementDaoExtensionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetCategoryByIDTest() {
            // ARRANGE.
            var idCategory = 1;
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            // ACT.
            objCategoryDAO.GetEntityByID(idCategory);            
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetCategoryNamesTest() {                                 
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();            
            objCategoryDAO.GetCategoryNames();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetNumberCategoriesTest() {            
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            objCategoryDAO.GetNumberCategories();
        }
    }
}