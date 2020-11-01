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
            IEmployeeDAO objEmployeeDAO = new EmployeeImplementDAO();
            var objEmployee = new Employee();

            //ACT
            objEmployeeDAO.RegisterEmployee(objEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ListEmployeesTest() {
            IEmployeeDAO objEmployeeDAO = new EmployeeImplementDAO();
            //ACT.
            objEmployeeDAO.ListEmployees();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteEmployeeTest() {         
            int idEmployee = 0;
            IEmployeeDAO objEmployeeDAO = new EmployeeImplementDAO();

            //ACT.
            objEmployeeDAO.DeleteEmployee(idEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdateEmployeeTest() {
            var objEmployee = new Employee();
            IEmployeeDAO objEmployeeDAO = new EmployeeImplementDAO();

            //ACT.
            objEmployeeDAO.UpdateEmployee(objEmployee);
        }
    }
}