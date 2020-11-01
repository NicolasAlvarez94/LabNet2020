using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dao.ImplementDAO
{
    public class EmployeeImplementDAO : IEmployeeDAO
    {
        private NorthwindContext dbContext;

        public EmployeeImplementDAO() {
            this.dbContext = this.GetSingleInstanceContext();            
        }

        // Singleton
        private NorthwindContext GetSingleInstanceContext() {         
            bool validateSingleInstance = this.dbContext == null;

            if (validateSingleInstance) {             
                this.dbContext = new NorthwindContext();
            }
            return dbContext;
        }


        #region Metodos Publicos

        // Metodos de Acceso a Datos, Invocados en la Capa de Logica.
        // La Insercion y Actualizacion de Empleados no se Utilizo Todos los Campos. 

        public void RegisterEmployee(Employee employee) {
            try {             
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public List<Employee> ListEmployees() {
            try {
                List<Employee> listEmployees = this.dbContext.Employees.ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void DeleteEmployee(int id) {
            try {
                var objEmployee = (from employe in dbContext.Employees
                                   where employe.EmployeeID == id
                                   select employe).First();

                dbContext.Employees.Remove(objEmployee);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void UpdateEmployee(Employee employee) {
            try {
                var objEmployee = (from employe in dbContext.Employees
                                   where employe.EmployeeID == employee.EmployeeID
                                   select employe).First();

                objEmployee.FirstName = employee.FirstName;
                objEmployee.LastName = employee.LastName;
                objEmployee.BirthDate = employee.BirthDate;
                objEmployee.HireDate = employee.HireDate;               
                objEmployee.City = employee.City;
                objEmployee.Region = employee.Region;                
                objEmployee.Country = employee.Country;
                objEmployee.HomePhone = employee.HomePhone;
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion

    }
}
