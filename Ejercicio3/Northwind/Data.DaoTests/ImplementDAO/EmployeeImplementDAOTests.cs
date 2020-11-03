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
    public class EmployeeImplementDAOTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RegisterEmployeeTest() {         
            // ARRANGE.
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();
            var objEmployee = new Employee();

            //ACT
            objEmployeeDAO.RegisterEntity(objEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ListEmployeesTest() {
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();
            //ACT.
            objEmployeeDAO.GetListEntities();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteEmployeeTest() {         
            int idEmployee = 0;
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();

            //ACT.
            objEmployeeDAO.DeleteEntity(idEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdateEmployeeTest() {
            var objEmployee = new Employee();
            IEntityDAO<Employee> objEmployeeDAO = new EmployeeImplementDAO();

            //ACT.
            objEmployeeDAO.UpdateEntity(objEmployee);
        }
    }
}