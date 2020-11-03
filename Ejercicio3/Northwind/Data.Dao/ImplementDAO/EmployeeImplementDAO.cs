using Data.Dao.InterfacesDAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dao.Context;

namespace Data.Dao.ImplementDAO
{
    public class EmployeeImplementDAO : BaseContextDAO, IEntityDAO<Employee>
    {

        // Contexto Heredado de la BaseContextDao, se Genera Instancia en lel Constructor de la Clase Base.
        public EmployeeImplementDAO() { }
            
        
        #region Metodos Publicos

        // Metodos de Acceso a Datos, Invocados en la Capa de Logica.
        // La Insercion y Actualizacion de Empleados no se Utilizo Todos los Campos. 

        public void RegisterEntity(Employee employee) {
            try {             
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public List<Employee> GetListEntities() {
            try {             
                List<Employee> listEmployees = dbContext.Employees.ToList();
                return listEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void DeleteEntity(int id) {
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


        public void UpdateEntity(Employee employee) {
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


        public Employee GetEntityByID(int id) {
            try {             
                var objEmployee = (from employee in dbContext.Employees
                                   where employee.EmployeeID == id
                                   select employee).First();
                return objEmployee;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion

    }
}
