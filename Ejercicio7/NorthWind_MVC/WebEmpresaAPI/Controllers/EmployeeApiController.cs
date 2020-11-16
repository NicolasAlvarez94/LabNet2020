using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntidadesAPI;
using DatosAPI.Interface;
using DatosAPI.ImplementacionDAO;


namespace WebEmpresaAPI.Controllers
{
    public class EmployeeApiController : ApiController
    {
        private readonly IEntidadApiDAO<EMPLOYEE> employeeDao;

        public EmployeeApiController() {
            this.employeeDao = new EmployeeApiImplementacionDAO();
        }

        

        // GET: api/EmployeeApi
        public List<EMPLOYEE> Get() {         
            try {             
                return employeeDao.TraerDatos();
            }
            catch (Exception ex) { throw ex; }       
        }



        // GET: api/EmployeeApi/5
        public EMPLOYEE Get(int id) {
            try {             
                EMPLOYEE objEmpleado = employeeDao.TraerPorID(id);
                return objEmpleado;
            }
            catch (Exception ex) { throw ex; }                                       
        }



        // POST: api/EmployeeApi
        public HttpResponseMessage Post([FromBody] EMPLOYEE employee)
        {
            HttpResponseMessage response = null;
            try {             
                employeeDao.Registrar(employee);
                var mensaje = "El empleado se ha registrado correctamente";
                response = Request.CreateResponse(HttpStatusCode.OK, mensaje);
                return response;
            }
            catch (Exception ex) {             
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                return response;
            }
        }


        // PUT: api/EmployeeApi/5
        public HttpResponseMessage Put(int id, [FromBody] EMPLOYEE employee) {         
            HttpResponseMessage response = null;
            try {             
                employeeDao.Modificar(employee);
                var mensaje = "El empleado se ha modificado correctamente";
                response = Request.CreateResponse(HttpStatusCode.OK, mensaje);
                return response;
            }
            catch (Exception ex) {             
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                return response;
            }
        }



        // DELETE: api/EmployeeApi/5
        public HttpResponseMessage Delete(int id) {         
            HttpResponseMessage response = null;
            try {             
                employeeDao.Eliminar(id);
                var mensaje = "El empleado se ha eliminado correctamente";
                response = Request.CreateResponse(HttpStatusCode.OK, mensaje);
                return response;
            }
            catch (Exception ex) {             
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                return response;
            }
        }


    }
}