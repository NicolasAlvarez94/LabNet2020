using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Dao.ExtensionImplementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.ImplementDAO;
using Data.Dao.InterfacesDAO;
using Entities;

namespace Data.Dao.ExtensionImplementDAO.Tests
{
    [TestClass()]
    public class EmployeeImplementDaoExtensionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetEmployeeByIDTest() {         
            // ARRANGE
            var idEmployee = 2;
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();

            //ACT 
            objEmployeeDAO.GetEntityByID(idEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetEmployeesByCityTest() {                     
            var city = "Texas";
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();
            //ACT 
            objEmployeeDAO.GetEmployeesByCity(city);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetEmployeesByHireDateTest() {                                 
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();
            //ACT 
            objEmployeeDAO.GetEmployeesByHireDate();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetNumberOfEmployeesTest() {                     
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();
            // ACT. 
            objEmployeeDAO.GetNumberOfEmployees();                       
        }
    }
}