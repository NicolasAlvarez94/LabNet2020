using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dao.ExtensionImplementDAO
{
    public static class EmployeeImplementDaoExtensions
    {
        private static NorthwindContext dbContext = new NorthwindContext();


        // Metodos de Extension de Acesso a Datos, Extienden la Funcionalidad de EmployeeImplementDAO.

        public static Employee GetEmployeeByID(this IEmployeeDAO IEmployee, int id) {            
            try {
                var objEmployee = (from employee in dbContext.Employees
                                   where employee.EmployeeID == id
                                   select employee).First();
                return objEmployee;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public static List<Employee> GetEmployeesByCity (this IEmployeeDAO IEmployee, string city) {
            try {
                var listEmployees = (from employee in dbContext.Employees
                                   where employee.City == city
                                   select employee).ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public static List<Employee> GetEmployeesByHireDate(this IEmployeeDAO IEmployee) {
            try {             
                var listEmployees = (from employee in dbContext.Employees
                                     orderby employee.HireDate descending
                                     select employee).ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public static int GetNumberOfEmployees(this IEmployeeDAO IEmployee) {
            try {
                var intNumberEmployees = (from employee in dbContext.Employees
                                     select employee).Count();
                return intNumberEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

    }
}
