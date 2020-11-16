using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAPI;
using DatosAPI.Interface;
using DatosAPI.Contexto;

namespace DatosAPI.ImplementacionDAO
{
    public class EmployeeApiImplementacionDAO: BaseApiContext, IEntidadApiDAO<EMPLOYEE>
    {

        #region Metodos Publicos

        public void Registrar(EMPLOYEE employee) {
            try {             
                dbContext.EMPLOYEES.Add(employee);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void Eliminar(int id) {
            try {             
                var objEmployee = (from employee in dbContext.EMPLOYEES
                                   where employee.ID == id
                                   select employee).First();

                dbContext.EMPLOYEES.Remove(objEmployee);
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void Modificar(EMPLOYEE pEmployee) {
            try {             
                var objEmployee = (from employee in dbContext.EMPLOYEES
                                   where employee.ID == pEmployee.ID
                                   select employee).First();

                objEmployee.FIRST_NAME = pEmployee.FIRST_NAME;
                objEmployee.LAST_NAME = pEmployee.LAST_NAME;
                objEmployee.SALARY = pEmployee.SALARY;
                objEmployee.HIRE_DATE = pEmployee.HIRE_DATE;
                dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public List<EMPLOYEE> TraerDatos() {
            try {             
                List<EMPLOYEE> listaEmployees = (from employee in dbContext.EMPLOYEES
                                                 select employee).ToList();
                return listaEmployees;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public EMPLOYEE TraerPorID(int id) {
            try {             
                var objEmployee = (from employee in dbContext.EMPLOYEES
                                   where employee.ID == id
                                   select employee).First();
                return objEmployee;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion

    }
}
