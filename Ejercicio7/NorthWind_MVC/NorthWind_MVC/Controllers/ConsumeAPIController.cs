using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Entidades.EntidadesExceptionAPI;
using Newtonsoft.Json;
using EntidadesAPI;


namespace NorthWind_MVC.Controllers
{
    public class ConsumeAPIController : Controller
    {        

        // Muestra las provincias consumida de una API publica.
        public async Task<ActionResult> GetAPI() {
            try {
                ProvinciaModeloJson provincias = null;
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync("https://apis.datos.gob.ar/georef/api/provincias");

                if (response.IsSuccessStatusCode) {                    
                    var json = await httpClient.GetStringAsync("https://apis.datos.gob.ar/georef/api/provincias");
                    provincias = JsonConvert.DeserializeObject<ProvinciaModeloJson>(json);
                }
                else {                   
                    throw new ErrorRespuestaHttpApiException();
                }
                return View(provincias);
            }
            catch (ErrorRespuestaHttpApiException ex) {                
                return View("ErrorAPI", ex);
            }
            catch (Exception) { 
                return RedirectToAction("ErrorAPI");
            }            
        }



        // Consumiendo API propia, listamos los datos de los empleados traidos desde la API propia.
        
        public async Task<ActionResult> GetApiEmployeesList() {
            try {             
                List<EMPLOYEE> empleados = null;
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync("http://localhost:9111/api/EmployeeApi");

                if (response.IsSuccessStatusCode) {                 
                    var json = await httpClient.GetStringAsync("http://localhost:9111/api/EmployeeApi");
                    empleados = JsonConvert.DeserializeObject<List<EMPLOYEE>>(json);
                }
                else {
                    throw new ErrorRespuestaHttpApiException();
                }
                return View(empleados);
            }

            catch (ErrorRespuestaHttpApiException ex) {
                return View("ErrorAPI", ex);
            }                                    
            catch (Exception) {
                return RedirectToAction("ErrorAPI");
            }                                        
        }



        // No implementado en front. Consume un Empleado desde la API propia.
        public async Task<ActionResult> GetApiEmployeeId() {         
            string id = Request.Form["FiltroId"];
            try {             
                EMPLOYEE objEmpleado = null;
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync("http://localhost:9111/api/EmployeeApi/" + id);

                if (response.IsSuccessStatusCode) {                 
                    var json = await httpClient.GetStringAsync("http://localhost:9111/api/EmployeeApi/" + id);
                    objEmpleado = JsonConvert.DeserializeObject<EMPLOYEE>(json);
                }
                else {                 
                    throw new ErrorRespuestaHttpApiException();
                }
                return View(objEmpleado);
            }
            catch (ErrorRespuestaHttpApiException ex) {             
                return View("ErrorAPI", ex);
            }
            catch (Exception) {             
                return RedirectToAction("ErrorAPI");
            }
        }



        public ActionResult ErrorAPI() {
            return View();
        }




    }
}