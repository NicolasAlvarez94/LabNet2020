using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Dao.InterfacesDAO;
using Data.Dao.ImplementDAO;
using Data.Dao.ExtensionImplementDAO;

namespace Logic
{
    public class EmployeeLogic
    {
        private IEmployeeDAO employeeDAO;

        public EmployeeLogic() {
            this.employeeDAO = new EmployeeImplementDAO();
        }


        #region Metodos Publicos

        // Metodos de Logica, Recibe Peticiones y Eventos de la Capa Presentacion y Delega la tarea a la Capa de Datos.

        public void RegisterEmployee(Employee employee) {
            employeeDAO.RegisterEmployee(employee);
        }
        public List<Employee> ListEmployees() {
            var listEmployees = employeeDAO.ListEmployees();
            return listEmployees;
        }

        public void DeleteEmployee(int id) {
            employeeDAO.DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee employee) {
            employeeDAO.UpdateEmployee(employee);
        }

        public Employee GetEmployeeID(int id) {                     
            var objEmployee = employeeDAO.GetEmployeeByID(id);
            return objEmployee;
        }

        public List<Employee> GetEmployeesByCity(string city) {
            var listEmployees = employeeDAO.GetEmployeesByCity(city);
            return listEmployees;
        }

        public List<Employee> GetEmployeesByHireDate() {
            var listEmployees = employeeDAO.GetEmployeesByHireDate();
            return listEmployees;
        }

        public int GetNumberOfEmployees() {
            var intNumberEmployees = employeeDAO.GetNumberOfEmployees();
            return intNumberEmployees;
        }

        #endregion

    }
}
