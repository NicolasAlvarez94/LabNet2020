using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Dao.ImplementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.InterfacesDAO;
using Entities;

namespace Data.Dao.ImplementDAO.Tests
{
    [TestClass()]
    public class CategoryImplementDAOTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RegisterCategoryTest()
        {
            // ARRANGE.
            var objCategory = new Category();
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            // ACT.
            objCategoryDAO.RegisterEntity(objCategory);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ListCategoriesTest()
        {
            var objCategory = new Category();
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            // ACT.
            objCategoryDAO.GetListEntities();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteCategoryTest() {
            var idCategory = 1;
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            // ACT.
            objCategoryDAO.DeleteEntity(idCategory);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdateCategoryTest() {         
            var objCategory = new Category();
            IEntityDAO<Category> objCategoryDAO = new CategoryImplementDAO();
            // ACT.
            objCategoryDAO.UpdateEntity(objCategory);
        }
    }
}