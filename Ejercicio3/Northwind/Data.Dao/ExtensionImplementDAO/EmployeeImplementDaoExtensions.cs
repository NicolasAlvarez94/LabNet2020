using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.Context;

namespace Data.Dao.ExtensionImplementDAO
{
    public static class EmployeeImplementDaoExtensions
    {
        private static NorthwindContext dbContext = new NorthwindContext();


        // Metodos de Extension de Acesso a Datos, Extienden la Funcionalidad de EmployeeImplementDAO.

        #region Metodos Publicos


        public static List<Employee> GetEmployeesByCity (this IEntityDAO<Employee> IEmployee, string city) {
            try {
                var listEmployees = (from employee in dbContext.Employees
                                   where employee.City == city
                                   select employee).ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public static List<Employee> GetEmployeesByHireDate(this IEntityDAO<Employee> IEmployee) {
            try {             
                var listEmployees = (from employee in dbContext.Employees
                                     orderby employee.HireDate descending
                                     select employee).ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public static int GetNumberOfEmployees(this IEntityDAO<Employee> IEmployee) {
            try {
                var intNumberEmployees = (from employee in dbContext.Employees
                                     select employee).Count();
                return intNumberEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion
    }
}
